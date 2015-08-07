using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroneOSClient
{
    static class DroneOSClient
    {
        //Start static variables
        public static Boolean manualMode {get; set;}
        //End static variables

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            manualMode = true;//Defaults the drone into manuel mode.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
        }
    }
}
