using DroneOSClient;
using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using DroneOS.Handlers;

//add namepsace later
public class SerialCon
{
    SerialPort _serialPort;

    public byte whatever = 24;

    public void startSerial()
    {
        if (!setComPort())
        {
            ErrorLog.println("[FATAL] Could not communicate with Arduino");//TODO: Program error handling w/ levels.
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
                ErrorLog.println("Checking port for Arduino " + port);
                if (DetectArduino()){
                    ErrorLog.println("Connected to Arduino on " + port);
                    return true;//Return when we have the correct port
                }
            }
        }
        catch (Exception e)
        {
            ErrorLog.println("Error in setComPort(): " + e);
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

            ErrorLog.println("Running detection test");

            int intReturnASCII = 0;
            char charReturnValue = (Char)intReturnASCII;
            _serialPort.Open();

            String textBuff = "byte: {";
            foreach (byte x in buffer)
                textBuff += " " + x;
            ErrorLog.println(textBuff + " }");

            _serialPort.Write(buffer, 0, 5);
            ErrorLog.println("wrote to arduino");
            Thread.Sleep(200);
            
            //receiving
            int count = _serialPort.BytesToRead;
            ErrorLog.println("return bytes: " + count);
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
            ErrorLog.println("Error in DetectArduino(): " + e);
            return false;
        }
    }

    /// <summary>Send control packet to arduino software. share this with tcp/ip packet creator later </summary>
    /// <param name="opcode">Packet Opcode</param>
    /// <param name="control">Control #. Reference controls.txt<param>
    /// <param name="outPin">Arudino PWM out pin</param>
    /// <param name="value">Force 1-5 is positive, 6-10 is reverse, signal sent to ESC</param>
    public void betaControlPacket(byte opcode, byte control, byte outPin, byte force = 1)
    {
        byte[] packet = new byte[5];
        packet[0] = Convert.ToByte(opcode);//TODO: create opcode files later
        packet[1] = Convert.ToByte(control);
        packet[2] = Convert.ToByte(outPin);//Aurdino output
        packet[3] = Convert.ToByte(force);
        packet[4] = Convert.ToByte(4);
        sendPacket(packet);
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

    public void sendPacket(byte[] packet)
    {
        _serialPort.Write(packet, 0, packet.Length);
    }
}