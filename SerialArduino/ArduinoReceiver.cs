using System;
using System.IO.Ports;

namespace SerialArduino
{

    class ArduinoReceiver
    {

        static void Main(string[] args)
        {
            SerialPort sp = new SerialPort("COM5", 9600);
            Console.WriteLine("Hello World!");
            sp.Open();
            while(true)
            {
                string data_r = sp.ReadLine();
                Console.WriteLine(data_r);
            }
        }
    }
}
