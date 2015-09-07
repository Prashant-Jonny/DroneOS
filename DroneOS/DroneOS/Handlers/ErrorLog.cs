using DroneOSClient;
using System;

namespace DroneOS.Handlers
{
    static class ErrorLog
    {
        public enum Error : byte
        {
            NONE = 0,
            FATAL = 1,
            WARNING,
            INFO
        }

        public static void println(String message, Error x = Error.NONE)
        {
            mainForm._mainForm.println(message);
        }
    }
}
