using System.Windows.Forms;

namespace DroneOS.Handlers
{
    public class MotorControl
    {
        private bool initialized {get; set;}

        public MotorControl() {
            initialized = true;
        }

        internal void ctrlForward(byte force)
        {
            //SerialConHandler
        }

        internal void ctrlReverse(byte force)
        {
        }

        internal void ctrlRotateL(byte force)
        {
        }

        internal void ctrlRotateR(byte force)
        {
        }

        //Vertical and Scew Controls
        internal void ctrlTransverseL(byte force)
        {
        }

        internal void ctrlTransverseR(byte force)
        {
        }

        internal void ctrlDive(byte force)
        {
        }

        internal void ctrlRise(byte force)
        {
        }

        internal void ctrlSurface(byte force)
        {
        }
    }
}