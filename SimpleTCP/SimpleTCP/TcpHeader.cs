using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleTCP
{
   public class TcpHeader
    {
        public TcpHeader()
        {
            BitArray sourcePort = new BitArray(16);
            BitArray destinationPort = new BitArray(16);
            BitArray sequencePort = new BitArray(32);
            BitArray acknowlegementNumber = new BitArray(32);
            BitArray dataOffset = new BitArray(4);  //needs to be 4 bits
            BitArray reversed = new BitArray(3); //needs to be 6 bits
            BitArray controlBits = new BitArray(6); //needs to be 6 bits
            BitArray CWR = new BitArray(1)
            ushort window;
            ushort checkSum;
            ushort urgentPointer;
            ushort tcpOptions;
            ushort padding;
            ushort tcpData;

        }





        public static void ConstructPacket()
        {
            
        }

    }
}
