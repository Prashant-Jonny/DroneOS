using DroneOSClient.NetworkEngine;

namespace DroneOSClient.Handlers
{
    public class ConsoleCommandHandler
    {
        private SerialConn serial;

        public ConsoleCommandHandler(SerialConn s)
        {
            ErrorLog.println(Error.Info, "(5/5) ConsoleCommandHandler Started\n");
            this.serial = s;
        }
        public void processCommand(string args)
        {
            args = args.ToLower();
            string[] splitted = args.Split(' ');

            if (splitted[0].Equals("cls"))
                MainForm._mainForm.cls();
            else
                ErrorLog.println("Not a command!");
        }
    }
}