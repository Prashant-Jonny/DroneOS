using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using DroneOSClient.ErrorLog;
using DroneOSClient.Constants;

public class TcpServer
{
    private bool init = false;
    private ASCIIEncoding AsciiAssembler = new ASCIIEncoding();

    private TcpListener listener;
    private Socket socket;

    public TcpServer()
    {
        start();
    }

    public void start()
    {
        init = true;
    }

    public void listen()
    {
        try
        {
            listener = new TcpListener(IPAddress.Parse(Constants.MicroIP), Constants.MicroPort);
            listener.Start();

            init = true;
            ErrorLog.println("The local End point is  :" + listener.LocalEndpoint);

            socket = listener.AcceptSocket();
            ErrorLog.println("Connection accepted from " + socket.RemoteEndPoint);

            byte[] packet = new byte[100];
            int bufferSize = socket.Receive(packet);
            ErrorLog.println("Recieving...");
            for (int i = 0; i < bufferSize; i++)
                ErrorLog.print(Convert.ToString(packet[i]));
            socket.Send(AsciiAssembler.GetBytes("The string was recieved by the server."));
            ErrorLog.println("\nSent Acknowledgement");
            //TODO: Clean up at form close and make class constants
            socket.Close();
            listener.Stop();
            //process opcodes?
            //seperate objects for each type of packet, motor, sensor or camera. Same in server software.
        }
        catch (Exception e)
        {
            ErrorLog.println("Error in TcpServer " + e.StackTrace);
        }
    }

    public void stop()
    {
    }

    public void reEstablish()
    {
    }
}