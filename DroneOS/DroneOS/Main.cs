using System;
using System.Windows.Forms;
using System.Threading;
using DroneOS.Handlers;

namespace DroneOSClient
{
    public partial class mainForm : Form
    {
        //Constants
        public bool manuelControl {get; set;}
        public bool active {get; set;}//wether or not the drone is active or "paused"
        public byte debugFlag {get; set;}//0 = none, 1 = some, 2 = verbose
        private bool goodStart {get; set;}
        public static mainForm _mainForm;//Self declaration to reference in other files

        private MotorControl motors = new MotorControl();
        private ControllerProcessor controller = new ControllerProcessor();
        private SerialCommandHandler commandHandler = new SerialCommandHandler();
        private SerialConHandler serialCon = new SerialConHandler();

        public mainForm()
        {
            //process xbox
            InitializeComponent();
            _mainForm = this;
            Thread serialConThread = new Thread(serialCon.startSerial);
            serialConThread.Start();
        }

        private void executeCommand(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                println(txtConsole.Text);
                SerialCommandHandler.processCommand(txtConsole.Text);
                txtConsole.Text = "";//Clear console input after processing
            }
        }

        public void print(String x)
        {
            debugBox.AppendText(x);
        }

        delegate void SetTextCallback(string text);//Thread Safety

        public void println(String x)
        {
            if (this.debugBox.InvokeRequired)
            {
                SetTextCallback c = new SetTextCallback(println);
                this.Invoke(c, new object[] {x});
            }
            else
                debugBox.AppendText(x + "\n");
        }

        public void cls()
        {
            debugBox.Text = "";
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
                println("Manuel Mode Active");
                btnManual.Text = "Auto";
            }
            else
            {
                println("Autonomous mode active");
                btnManual.Text = "Manuel";
            }
        }

        private void btnAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Software developed by Owen Wolf (owen@gowolf.io)\r\n\r\n East Los Angeles College Robo Sub\r\n");
        }

        private void toggleStartStop(object sender, EventArgs e)
        {
            active = !active;//Switch cases
            if (active)
            {
                btnStartStop.BackColor = System.Drawing.Color.LightCoral;
                println("Program started");
                btnStartStop.Text = "Pause";
            }
            else
            {
                btnStartStop.BackColor = System.Drawing.Color.PaleGreen;
                println("Program paused");
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
            //TODO: Program termination arguements
            //TODO: Add static constant to check if program already terminated or not. De initliaze all handlers? Rise command?
            println("Program terminated");
        }

        //Motor Controls
        private void btnRaise_Click(object sender, EventArgs e)
        {
            motors.ctrlRise((byte) 10);
        }

        private void btnDive_Click(object sender, EventArgs e)
        {
            motors.ctrlDive((byte)10);
        }

        private void btnTranL_Click(object sender, EventArgs e)
        {
            motors.ctrlTransverseL((byte)10);
        }

        private void btnTranR_Click(object sender, EventArgs e)
        {
            motors.ctrlTransverseR((byte)10);
        }

        private void btnRotateL_Click(object sender, EventArgs e)
        {
            motors.ctrlRotateL((byte)10);
        }

        private void btnRotateR_Click(object sender, EventArgs e)
        {
            motors.ctrlRotateR((byte)10);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            motors.ctrlForward((byte)10);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            motors.ctrlReverse((byte)10);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            controller.UpdateInput();
        }

        private void debugBox_TextChanged(object sender, EventArgs e)
        {
            debugBox.SelectionStart = debugBox.Text.Length; //Set the current caret position at the end
            debugBox.ScrollToCaret();//Now scroll it automatically
        }
    }
}