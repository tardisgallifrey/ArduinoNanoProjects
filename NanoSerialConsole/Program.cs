using System;
using NanoSerialLib;

namespace NanoSerialConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            var nano = new Board(9600, "/dev/ttyUSB0");
            
            do
            {
               message = Console.ReadLine();
               nano.Write(message);

               Console.Write(nano.Read());

            }while(message != "q");

            nano.Close();

        }
    }
}
