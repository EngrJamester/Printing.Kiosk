using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using Printing.Kiosk.Forms;

namespace Printing.Kiosk.Classes
{
    public class SerialPort
    {
        SerialPort ComPort = new SerialPort();
        

        public  string GetPorts()
        {
            ComputationSummary CompSum = new ComputationSummary();
            string portName="";

            Console.WriteLine("Available Ports:");
            foreach (char s in GetPorts())
            {
                Console.WriteLine(s.ToString());
            }



            //if (portName == "" || !(portName.ToLower()).StartsWith("com"))
            //{
            //    portName = defaultPortName;
            //}
            
            return portName;
        }
    }
}
