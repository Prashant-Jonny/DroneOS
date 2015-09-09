using System;
using System.Windows.Forms;

namespace DroneOSClient
{
    static class DroneOSClient
    {
        //Start static variables
        public const string DroneIP = "127.0.0.1";
        public const int DronePort = 626;
        //End static variables

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
        }
    }
}
