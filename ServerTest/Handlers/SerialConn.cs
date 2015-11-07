using DroneOSClient.Handlers;
using System;
using System.IO.Ports;
using System.Threading;

namespace DroneOSClient.NetworkEngine
{
    public class SerialConn
    {
        private SerialPort _serialPort;

        public SerialConn() {
            ErrorLog.println(Error.Info, "(1/5) SerialCon Started");
        }

        public void startCon()
        {
            if (!setComPort())
            {
                ErrorLog.println(Error.Fatal, "Could not communicate with Arduino");
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
                    ErrorLog.println("Checking port for Arduino " + port);
                    if (detectArduino())
                    {
                        ErrorLog.println("Connected to Arduino on " + port);
                        return true;//Return when we have the correct port
                    }
                    else
                        _serialPort.Close();
                }
            }
            catch (Exception e)
            {
                ErrorLog.println("Error in setComPort(): " + e);
            }
            return false;//Default to false if nothing is found
        }

        public bool detectArduino()//convert all these into functions later
        {
            try
            {
                ErrorLog.println(Error.Info, "Running detection test");
                _serialPort.Open();//Open the serial connection
                this.sendPacket(PacketCreator.SendHello());

                ErrorLog.println(Error.Info, "Wrote to arduino");
                Thread.Sleep(200);

                //Receiving
                int count = _serialPort.BytesToRead;
                ErrorLog.println(Error.Info, "return bytes count: " + count);

                string returnMessage = "";
                while (count > 0)//build character
                {
                    returnMessage += Convert.ToChar(_serialPort.ReadByte());
                    count--;
                }
                ErrorLog.println(Error.Info, "Arduino Returned: " + returnMessage);
                if (returnMessage.Contains("HELLO FROM ARDUINO"))
                    return true;
                else
                    return false;

            }
            catch (Exception e)
            {
                ErrorLog.println(Error.Info, "Error in DetectArduino(): " + e);
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
                ErrorLog.println(Error.Fatal, "Error closing connection " + e);
                return false;
            }
        }

        public void sendPacket(byte[] packet)
        {
            //_serialPort.Write(packet, 0, packet.Length); //Comment out if not connected
        }
    }
}