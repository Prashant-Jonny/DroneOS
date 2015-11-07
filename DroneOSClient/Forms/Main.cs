using System;
using System.Windows.Forms;
using DroneOSClient.Handlers;
using DroneOSClient.NetworkEngine;

namespace DroneOSClient
{
    public partial class MainForm : Form
    {
        //Constants
        public bool manuelControl { get; set; }
        public bool active { get; set; }//Whether or not the drone is active or "paused"
        private bool goodStart = false;
        public static MainForm _mainForm;//Self declaration to reference in other files

        //Connections
        private SerialConn serial;
        private TcpConn tcp;

        //Handlers
        private MotorHandler motors;
        private ControllerHandler controller;
        private ConsoleCommandHandler commandHandler;

        public MainForm()
        {
            InitializeComponent();
            _mainForm = this;
            //Start Cons
            serial = new SerialConn();
            tcp = new TcpConn();

            //Start Handlers
            motors = new MotorHandler(tcp);
            controller = new ControllerHandler(serial);
            commandHandler = new ConsoleCommandHandler(serial);
        }

        private void executeCommand(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                println(txtConsoleInput.Text);
                commandHandler.processCommand(txtConsoleInput.Text);
                txtConsoleInput.Text = "";//Clear console input after processing
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
                this.Invoke(c, new object[] { x });
            }
            else
                debugBox.AppendText(x + "\n");
        }

        public void cls()
        {
            debugBox.Text = "";
        }

        private void openMissionDialog(object sender, EventArgs e)
        {
            openMissionPlan.ShowDialog();
        }

        private void saveMissionDialog(object sender, EventArgs e)
        {
            saveMissionPlan.ShowDialog();
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
            MessageBox.Show("Software developed by:\r\n"
                + "Owen Wolf (owen@gowolf.io)\r\n"
                + "Krystal Bernal (krystalbc@sbcglobal.net) \r\n\r\n"
                + "For East Los Angeles College Robo Sub 2016\r\n");
        }

        private void toggleStartStop(object sender, EventArgs e)
        {
            active = !active;//Switch cases
            if (active)
            {
                if (!goodStart)
                {
                    Form cameraForm = new CameraFeed();
                    cameraForm.Show();
                    goodStart = true;
                }
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
            if (MessageBox.Show("Are you sure you want to exit?", "DroneOS Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;// Cancel the Closing event from closing the form.
            else
                serial.closeCon();
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
            motors.ctrlRise((byte)5);
        }

        private void btnDive_Click(object sender, EventArgs e)
        {
            motors.ctrlDive((byte)5);
        }

        private void btnTranL_Click(object sender, EventArgs e)
        {
            motors.ctrlTransverseL((byte)5);
        }

        private void btnTranR_Click(object sender, EventArgs e)
        {
            motors.ctrlTransverseR((byte)5);
        }

        private void btnRotateL_Click(object sender, EventArgs e)
        {
            motors.ctrlRotateL((byte)5);
        }

        private void btnRotateR_Click(object sender, EventArgs e)
        {
            motors.ctrlRotateR((byte)5);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            motors.ctrlForward((byte)5);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            motors.ctrlReverse((byte)5);
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

        private void btnRollLeft_Click(object sender, EventArgs e)
        {
            motors.ctrlRollLeft(1);
        }

        private void btnRollRight_Click(object sender, EventArgs e)
        {
            motors.ctrlRollRight(1);
        }
    }
}