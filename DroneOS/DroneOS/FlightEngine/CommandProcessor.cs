using System.Windows.Forms;

namespace DroneOSClient.flightEngine
{
    static class CommandProcessor
    {
        public void ProcessCommand()
        {
            while (!_shouldStop)
            {
                if (!gamePadState.IsConnected)
                {
                    MessageBox.Show("Xbox controller is not connected.");
                    RequestStop();
                    break;
                }
            }
            
            MessageBox.Show("Switching to autonomous mode");
        }

        public void RequestStop()
        {
            _shouldStop = true;
        }
        private volatile bool _shouldStop;
    }
}