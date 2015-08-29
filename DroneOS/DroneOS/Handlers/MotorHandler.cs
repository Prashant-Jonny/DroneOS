using System.Windows.Forms;

namespace DroneOS.Handlers
{
    public class MotorControl
    {
        private bool initialized { get; set; }
        SerialConHandler serialCon = new SerialConHandler();

        public MotorControl()
        {
            initialized = true;
        }

        internal void ctrlForward(byte force = 1)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.left, 5, force);
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.right, 5, force);
        }

        internal void ctrlReverse(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.left, 5, (byte)(force + 5));
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.right, 5, (byte)(force + 5));
        }

        internal void ctrlRotateL(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.left, 5, force);
        }

        internal void ctrlRotateR(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.right, 5, force);
        }

        //Vertical and Skew Controls
        internal void ctrlTransverseL(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.transRear, 0, force);
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.transFront, 0, force);
        }

        internal void ctrlTransverseR(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.transRear, 0, (byte)(force + 5));
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.transFront, 0, (byte)(force + 5));
        }


        internal void ctrlDive(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtFrontLeft, 0, (byte)(force + 5));
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtFrontRight, 0, (byte)(force + 5));
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtRearLeft, 0, (byte)(force + 5));
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtRearRight, 0, (byte)(force + 5));
        }

        internal void ctrlRise(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtFrontLeft, 0, force);
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtFrontRight, 0, force);
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtRearLeft, 0, force);
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtRearRight, 0, force);
        }

        internal void ctrlSurface(byte force)
        {

        }

        internal void ctrlPitchUp(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtFrontLeft, 0, force);
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtFrontRight, 0, force);
        }

        internal void ctrlPitchDown(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtFrontLeft, 0, (byte)(force + 5));
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtFrontRight, 0, (byte)(force + 5));
        }

        internal void ctrlRollRight(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtFrontRight, 0, (byte)(force + 5));
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtRearRight, 0, (byte)(force + 5));
        }

        internal void ctrlRollLeft(byte force)
        {
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtFrontLeft, 0, (byte)(force + 5));
            serialCon.sendControlPacket((byte)enums.sendOpcodes.Control, (byte)enums.motors.vrtRearLeft, 0, (byte)(force + 5));
        }
    } 
}