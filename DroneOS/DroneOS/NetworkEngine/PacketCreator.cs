using System;

namespace DroneOSClient.NetworkEngine
{
    class PacketCreator
    {
        public enum sendOpcodes : byte
        {
            Hello = 1,
            Control = 2
        }

        public enum recvOpcodes : byte
        {
            recvHello = 100
        }

        public static byte[] controlPacket(byte pin, byte force, bool reverse = false)
        {
            byte[] packet = new byte[4];

            packet[0] = (byte) sendOpcodes.Control;//Always start with 0
            packet[1] = pin;
            packet[2] = force;
            packet[3] = Convert.ToByte(reverse);

            return packet;
        }
    }
}
