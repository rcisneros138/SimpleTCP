using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;
using System.Collections;

namespace TCPconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestClass testClass = new TestClass();
            //Translator<object> translator = new Translator<object>(testClass);
            short sourcePort = 1;
            short destinationPort = 1;
            int SequencePort = 1;
            int acknowledgeNumber = 1;
            BitArray dataOff = new BitArray(4);
            BitArray reserved = new BitArray(3);
            bool[] flags = { true, true, false, false };
            short window = 1;
            short checksum = 1;
            short urgent = 1;
            int padding = 1;




            TcpHeader tcp = new TcpHeader(sourcePort, destinationPort, SequencePort, acknowledgeNumber, dataOff, reserved, flags, window, checksum, urgent, padding);
            //tcp.getInfo(65535,54434, 4294967295,50000,)

            
        }
    }
}
