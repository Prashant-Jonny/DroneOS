using System;
using System.IO.Ports;
using System.Threading;

namespace DroneOSServer.NetworkEngine
{
    public class SerialConn
    {
        private SerialPort _serialPort;

        public SerialConn() {
            Console.WriteLine("SerialCon Started");
        }

        public void startCon()
        {
            if (!setComPort())
            {
                Console.WriteLine("Could not communicate with Arduino");
                return;
            }
        }

        private bool setComPort()//Returns boolean if finding the Arduino was successful
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();//Get all COM ports from the system
                foreach (string port in ports)//Cycle thru COM ports
                {
                    _serialPort = new SerialPort(port, 9600);//Set up serial port w/ this bit transfer rate
                    Console.WriteLine("Checking port for Arduino " + port);
                    if (detectArduino())
                    {
                        Console.WriteLine("Connected to Arduino on " + port);
                        return true;//Return when we have the correct port
                    }
                    else
                        _serialPort.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in setComPort(): " + e);
            }
            return false;//Default to false if nothing is found
        }

        public bool detectArduino()//convert all these into functions later
        {
            try
            {
                Console.WriteLine("Running detection test");
                _serialPort.Open();//Open the serial connection
                this.sendPacket(PacketCreator.SendHello());

                Console.WriteLine("Wrote to arduino");
                Thread.Sleep(200);

                //Receiving
                int count = _serialPort.BytesToRead;
                Console.WriteLine("return bytes count: " + count);

                string returnMessage = "";
                while (count > 0)//build character
                {
                    returnMessage += Convert.ToChar(_serialPort.ReadByte());
                    count--;
                }
                Console.WriteLine("Arduino Returned: " + returnMessage);
                if (returnMessage.Contains("HELLO FROM ARDUINO"))
                    return true;
                else
                    return false;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error in DetectArduino(): " + e);
                return false;
            }
        }

        public bool closeCon()
        {
            try
            {
                _serialPort.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error closing connection " + e);
                return false;
            }
        }

        public void sendPacket(byte[] packet)
        {
            //_serialPort.Write(packet, 0, packet.Length); //Comment out if not connected
        }
    }
}