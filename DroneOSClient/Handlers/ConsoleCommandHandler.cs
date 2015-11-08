using DroneOSServer.NetworkEngine;

namespace DroneOSServer.Handlers
{
    public class ConsoleCommandHandler
    {
        public ConsoleCommandHandler()
        {
            ErrorLog.println(Error.Info, "(5/5) ConsoleCommandHandler Started\n");
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