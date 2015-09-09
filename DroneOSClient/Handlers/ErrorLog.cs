using DroneOSClient;
using System;

namespace DroneOSClient.Handlers
{
    enum Error
    {
        Info, Warning, Fatal
    }

    static class ErrorLog
    {
        public static void println(String message)
        {
            MainForm._mainForm.println(message);
        }

        public static void println(Error e, String m)
        {
            MainForm._mainForm.println(m);
            //MainForm._mainForm.println(e.ToString() + " : " + m);
        }
    }
}
