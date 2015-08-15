using DroneOSClient;
using System;

namespace DroneOS.Handlers
{
    class ErrorLog
    {
        public enum Error
        {
            NONE,
            FATAL,
            WARNING,
            INFO
        }

        public void println(String message, Error x = Error.NONE)
        {
            mainForm._mainForm.println(message);
        }
    }
}
