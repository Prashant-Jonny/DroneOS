using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public class SerialController
{
    interface SerialInterface
    {
        SerialPort _serialPort;

        public void run()  
        {
            if (!setComPort())
                return;
            while (true)
            {
                //Interface commands here.
            }
        }

        private bool setComPort()//Returns boolean if finding the Arduino was successful
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();//Get all COM ports from the system
                foreach (string port in ports)//Cycle thru COM ports
                {
                    _serialPort = new SerialPort(port, 9600);//Set up bit transfer rate
                    if (DetectArduino())
                        return true;//Return when we have the correct port
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in setComPort(): " + e);
            }
            MessageBox.Show("Could not find Arduino.");
            return false;//Default to false if nothing is found
        }

        private bool DetectArduino()
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

                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                _serialPort.Open();
                _serialPort.Write(buffer, 0, 5);

                Thread.Sleep(100);

                int count = _serialPort.BytesToRead;
                string returnMessage = "";
                while (count > 0)
                {
                    intReturnASCII = _serialPort.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
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
                MessageBox.Show("Error in DetectArduino(): " + e);
                return false;
            }
        }
    }
}
