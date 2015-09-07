using DroneOS.Resources;
using DroneOSClient.NetworkEngine;
using System.Windows.Forms;

namespace DroneOS.Handlers
{
    public class MotorHandler
    {
        private bool initialized { get; set; }
        SerialCon serial = new SerialCon();

        public MotorHandler()
        {
            initialized = true;
        }

        internal void ctrlForward(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.left, force));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.right, force));
        }

        internal void ctrlReverse(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.left, force, true));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.right, force, true));
        }

        internal void ctrlRotateL(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.left, force));
        }

        internal void ctrlRotateR(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.right, force));
        }

        //Vertical and Skew Controls
        internal void ctrlTransverseL(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.transRear, force));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.transFront, force));
        }

        internal void ctrlTransverseR(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.transRear, force, true));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.transFront, force, true));
        }


        internal void ctrlDive(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtFrontLeft, force, true));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtFrontRight, force, true));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtRearLeft, force, true));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtRearRight, force, true));
        }

        internal void ctrlRise(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtFrontLeft, force));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtFrontRight, force));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtRearLeft, force));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtRearRight, force));
        }

        internal void ctrlSurface(byte force)
        {

        }

        internal void ctrlPitchUp(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtFrontLeft, force));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtFrontRight, force));
        }

        internal void ctrlPitchDown(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtFrontLeft, force, true));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtFrontRight, force, true));
        }

        internal void ctrlRollRight(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtFrontRight, force, true));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtRearRight, force, true));
        }

        internal void ctrlRollLeft(byte force)
        {
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtFrontLeft, force, true));
            serial.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrtRearLeft, force, true));
        }
    } 
}