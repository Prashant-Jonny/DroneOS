using DroneOSClient.Handlers;
using System;
using System.Net.Sockets;
using System.Text;

namespace DroneOSClient.NetworkEngine
{
    public class TcpConn
    {
        TcpClient clientSocket;
        NetworkStream ioStream;

        public TcpConn()
        {
            clientSocket = new TcpClient();
            if (connect())
                ErrorLog.println(Error.Info, "(2/5) TcpCon Started");
        }

        public bool connect() 
        {
            try
            {
                clientSocket.Connect(DroneOSClient.DroneIP, DroneOSClient.DronePort);
                ErrorLog.println("Connected on " + DroneOSClient.DroneIP + ":" + DroneOSClient.DronePort);
                return true;
            } catch (Exception e){
                ErrorLog.println(Error.Fatal, "Was not able to connect to TCP server:\n " + e);
                clientSocket.Close();
                return false;
            }
        }

        public void sendPacket(byte[] packet)
        {
            ioStream = clientSocket.GetStream();
            ioStream.Write(packet, 0, packet.Length);
            ioStream.Flush();
        }

        public void recvPacket()
        {
            int buffersize = (int)clientSocket.ReceiveBufferSize;
            byte[] inStream = new byte[buffersize];
            ioStream.Read(inStream, 0, buffersize);
        }

        public void disconnect() 
        {
            clientSocket.Close();
            ioStream.Close();
        }
    }
}