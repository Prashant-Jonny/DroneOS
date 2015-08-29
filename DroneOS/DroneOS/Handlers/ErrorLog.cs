using DroneOSClient;
using System;

namespace DroneOS.Handlers
{
    class ErrorLog
    {
        public enum Error
        {
            NONE = 0,
            FATAL = 1,
            WARNING,
            INFO
        }

        public void println(String message, Error x = Error.NONE)
        {
            mainForm._mainForm.println(message);
        }
    }
}
