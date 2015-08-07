using System;
using System.Windows.Forms;
using System.Threading;
using DroneOSClient.flightEngine;

namespace DroneOSClient
{

    public partial class Main : Form
    {
        //Setup for manuel xbox control thread
        bool manuelControl = true;
        static CommandProcessor xbox = new CommandProcessor();
        static Thread conrollerThread = new Thread(xbox.ProcessCommand);
        //Other constants


        public Main()
        {
            if (manuelControl)
            {
                conrollerThread.Start();
            }
            InitializeComponent();
        }

        private void executeCommand(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                String command = txtConsole.Text;
                txtConsole.Text = "";
                debugBox.Text += command + "\n";
            }
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
            Application.Exit();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            DroneOSClient.manualMode = !DroneOSClient.manualMode;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
