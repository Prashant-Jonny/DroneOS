using DroneOSClient;
using System;
using System.Windows.Forms;

namespace DroneOS.Handlers
{
    public class SerialCommandHandler
    {
        public static void processCommand(string args)
        {
            args = args.ToLower();
            string[] split = args.Split(' ');

            if (split[0].Equals("cls"))
                mainForm._mainForm.cls();
            else
                println("Not a command!");
        }

        private static void println(String message) 
        {
            mainForm._mainForm.println(message);
        }
    }
}
