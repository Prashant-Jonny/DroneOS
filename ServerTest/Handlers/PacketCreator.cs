using DroneOSServer.Resources;
using System;

namespace DroneOSServer.NetworkEngine
{
    class PacketCreator
    {
        public static byte[] SendHello()
        {
            byte[] packet = new byte[5];
            packet[0] = (byte)SendOpcodes.Hello;
            packet[1] = 128;
            packet[2] = 0;
            packet[3] = 0;
            packet[4] = 4;
            return packet;
        }

        public static byte[] controlPacket(byte pin, byte force, bool reverse = false)
        {
            byte[] packet = new byte[4];
            packet[0] = (byte) SendOpcodes.Thruster;//Always start with 0
            packet[1] = pin;
            packet[2] = force;
            packet[3] = Convert.ToByte(reverse);
            return packet;
        }
    }
}
