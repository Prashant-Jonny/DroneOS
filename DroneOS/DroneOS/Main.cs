using System;
using System.Windows.Forms;
using System.Threading;
using DroneOS.Handlers;

namespace DroneOSClient
{
    public partial class mainForm : Form
    {
        //Constants
        static bool manuelControl = true;
        static bool active = false;//wether or not the drone is active
        static byte debugFlag = 0;//0 = none, 1 = some, 2 = verbose
        public static mainForm _mainForm;//Self declaration to reference in other files

        public mainForm()
        {
            //process xbox
            InitializeComponent();
            _mainForm = this;
        }

        private void executeCommand(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SerialCommandHandler.processCommand(txtConsole.Text);
                printConsoleln(txtConsole.Text);
                txtConsole.Text = "";//Clear console input after processing
            }
        }

        public void printConsole(String x)
        {
            debugBox.AppendText(x + "\n");
        }

        public void printConsoleln(String x)
        {
            debugBox.AppendText(x + "\n");
        }

        private void openFlightDialog(object sender, EventArgs e)
        {
            openFlightPlan.ShowDialog();
        }

        private void saveFlightDialog(object sender, EventArgs e)
        {
            saveFlightPlan.ShowDialog();
        }

        private void mainExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switchManAuto(object sender, EventArgs e)
        {
            manuelControl = !manuelControl;
            if (manuelControl)
            {
                printConsoleln("Manuel Mode Active");
                btnManual.Text = "Auto";
            }
            else
            {
                printConsoleln("Autonomous mode active");
                btnManual.Text = "Manuel";
            }
        }

        private void btnAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Software developed by Owen Wolf for East Los Angeles College Robo Sub");
        }

        private void toggleStartStop(object sender, EventArgs e)
        {
            active = !active;//Switch cases
            if (active)
            {
                btnStartStop.BackColor = System.Drawing.Color.LightCoral;
                printConsoleln("Program resumed");
                btnStartStop.Text = "Pause";
            }
            else
            {
                btnStartStop.BackColor = System.Drawing.Color.PaleGreen;
                printConsoleln("Program paused");
                btnStartStop.Text = "Start";
            }
        }

        private void exitProgram(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "DroneOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;// Cancel the Closing event from closing the form.                
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnShutdown_click(object sender, EventArgs e)
        {
            MessageBox.Show("Drone power shut down");
        }
    }
}