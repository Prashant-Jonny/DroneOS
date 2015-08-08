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
            MessageBox.Show("test command split: " + split.ToString());

            if (split[0].Equals("test"))
            {
                print("TestCommand");
            }
            else
                print("Not a command");
        }

        private static void print(String message) 
        {
            mainForm._mainForm.printConsoleln(message);
        }
    }
}
