using System;
using System.IO.Ports;

namespace NanoSerialLib
{
    public class Board
    {
        static SerialPort _arduino;

        public Board(int Rate, string port)
        {
            _arduino = new SerialPort();
            _arduino.BaudRate = Rate;
            _arduino.PortName = port;
            _arduino.Open();
        }
       
        public string Read()
        {
            string value = "";
            if(_arduino.IsOpen)
            {
                value = _arduino.ReadLine();
            }
            return value;
        }

        public void Write(string message)
        {

            if(_arduino.IsOpen)
            {
                _arduino.Write(message);
            }
            else
            {
                throw new InvalidOperationException("Serial port not operating, write failed.");
            }

        }

        public void Close()
        {
             if(_arduino != null && _arduino.IsOpen)
            {
                _arduino.Close();
            }
            else
            {
                throw new InvalidOperationException("Serial port not responding");
            }
        }
    }
}