using DroneOSServer.Handlers;
using System;
using System.Net.Sockets;
using System.Text;

namespace DroneOSServer.NetworkEngine
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
                ioStream = clientSocket.GetStream();
                this.sendPacket(PacketCreator.SendHello());
                return true;
            } catch (Exception e){
                ErrorLog.println(Error.Fatal, "Was not able to connect to TCP server:\n " + e);
                clientSocket.Close();//Close to prevent possible memory leak in the heap
                return false;
            }
        }

        public void sendPacket(byte[] packet)
        {
            ErrorLog.print("Sending packet (2): ");
            printBytes(packet);
            ErrorLog.println("");
            ioStream.Write(packet, 0, packet.Length);
            ioStream.Flush();
        }

        private void printBytes(byte[] bytes)
        {
            foreach (byte x in bytes)
                ErrorLog.print(x + " ");
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