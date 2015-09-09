using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

class MyTcpListener
{
    public static void Main()
    {
        TcpListener server = null;
        try
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 626);
            server.Start();

            // Buffer for reading data
            Byte[] bytes = new Byte[256];
            String recvPacket = null;

            // Enter the listening loop. 
            while (true)
            {
                Console.Write("Waiting for a connection... ");

                // Perform a blocking call to accept requests. 
                // You could also user server.AcceptSocket() here.
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Connected!");

                recvPacket = null;

                // Get a stream object for reading and writing
                NetworkStream stream = client.GetStream();

                int i;

                // Loop to receive all the data sent by the client. 
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    recvPacket = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("Received: {0}", recvPacket);

                    byte[] sendPacket = System.Text.Encoding.ASCII.GetBytes(recvPacket);

                    // Send back a response.
                    stream.Write(sendPacket, 0, sendPacket.Length);
                    Console.WriteLine("Sent: {0}", recvPacket);
                }

                // Shutdown and end connection
                client.Close();
            }
        }
        catch (SocketException e)
        {
            Console.WriteLine("SocketException: {0}", e);
        }
        finally
        {
            // Stop listening for new clients.
            server.Stop();
        }
        Console.WriteLine("\nHit enter to continue...");
        Console.Read();
    }
}