using DroneOSClient;
using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using DroneOS.Handlers;

public class SerialConHandler
{
    SerialPort _serialPort;

    public void startSerial()
    {
        if (!setComPort())
        {
            println("[FATAL] Could not communicate with Arduino");//TODO: Program error handling w/ levels.
            return;
        }
        //Runtime arguements here

    }

    private bool setComPort()//Returns boolean if finding the Arduino was successful
    {
        try
        {
            string[] ports = SerialPort.GetPortNames();//Get all COM ports from the system
            foreach (string port in ports)//Cycle thru COM ports
            {
                _serialPort = new SerialPort(port, 9600);//Set up bit transfer rate
                println("Checking port for Arduino " + port);
                if (DetectArduino()){
                    println("Connected to Arduino on " + port);
                    return true;//Return when we have the correct port
                }
            }
        }
        catch (Exception e)
        {
            println("Error in setComPort(): " + e);
        }
        return false;//Default to false if nothing is found
    }

    public bool DetectArduino()//convert all these into functions later
    {
        try
        {
            //Setting are for the handshake
            byte[] buffer = new byte[5];
            buffer[0] = Convert.ToByte(16);
            buffer[1] = Convert.ToByte(128);
            buffer[2] = Convert.ToByte(0);
            buffer[3] = Convert.ToByte(0);
            buffer[4] = Convert.ToByte(4);

            println("Running detection test");

            int intReturnASCII = 0;
            char charReturnValue = (Char)intReturnASCII;
            _serialPort.Open();

            String textBuff = "byte: {";
            foreach (byte x in buffer)
                textBuff += " " + x;
            println(textBuff + " }");

            _serialPort.Write(buffer, 0, 5);
            println("wrote to arduino");
            Thread.Sleep(200);
            
            //receiving
            int count = _serialPort.BytesToRead;
            println("return bytes: " + count);
            string returnMessage = "";
            while (count > 0)//build character
            {
                intReturnASCII = _serialPort.ReadByte();
                returnMessage += Convert.ToChar(intReturnASCII);
                count--;
            }
            _serialPort.Close();
            if (returnMessage.Contains("HELLO FROM ARDUINO"))
                return true;
            else
                return false;

        }
        catch (Exception e)
        {
            println("Error in DetectArduino(): " + e);
            return false;
        }
    }

    /// <summary>Send control packet to arduino software. share this with tcp/ip packet creator later </summary>
    /// <param name="opcode">Packet Opcode</param>
    /// <param name="control">Control #. Reference controls.txt<param>
    /// <param name="outPin">Arudino PWM out pin</param>
    /// <param name="value">Force 1-5 is positive, 6-10 is reverse, signal sent to ESC</param>
    public void sendControlPacket(byte opcode, byte control, byte outPin, byte value = 1)
    {
        byte[] packet = new byte[5];
        packet[0] = Convert.ToByte(opcode);//TODO: create opcode files later
        packet[1] = Convert.ToByte(control);
        packet[2] = Convert.ToByte(outPin);//Aurdino output
        packet[3] = Convert.ToByte(value);
        packet[4] = Convert.ToByte(4);
        sendPacket(packet);
    }

    public void sendPacket(byte[] data)
    {
        _serialPort.Write(data, 0, 5);
    }

    public void recvPacket(byte[] data)
    {
        //packet headers in enums, seperate class file
        //Process incoming packet, send to seperate static handler
    }

    public void sendHandshake()
    {
        //Packet buffer
        byte[] packet = new byte[5];
        packet[0] = Convert.ToByte(16);
        packet[1] = Convert.ToByte(128);
        packet[2] = Convert.ToByte(0);
        packet[3] = Convert.ToByte(0);
        packet[4] = Convert.ToByte(4);
        sendPacket(packet);
    }

    private void println(String x)
    {
        mainForm._mainForm.println(x);
    }
}