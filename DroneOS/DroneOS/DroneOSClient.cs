using System;
using System.Windows.Forms;

namespace DroneOSClient
{
    static class DroneOSClient
    {
        //Start static variables
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
