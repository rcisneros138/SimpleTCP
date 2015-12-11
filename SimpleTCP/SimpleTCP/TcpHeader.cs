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
        byte[] SourcePort;
        byte[] DestinationPort;
        byte[] SequencePort;
        byte[] acknowlegementNumber;
        BitArray dataOffSet;
        BitArray reserved;
        bool[] flags;
        byte[] window;
        byte[] checkSum;
        byte[] urgentPointer;
        byte[] padding;





        public TcpHeader(short sourcePort, short destinationPort, int sequencePort, int acknowledgeNum, BitArray dataOff, BitArray Reserved, bool[] flag, short Window, short CheckSum, short Urgent, int Padding)
        {
            //SourcePort = new BitArray(BitConverter.GetBytes(sourcePort));
            SourcePort =  BitConverter.GetBytes(sourcePort);
            DestinationPort = BitConverter.GetBytes(destinationPort);
            SequencePort = BitConverter.GetBytes(sequencePort);
            acknowlegementNumber = BitConverter.GetBytes(acknowledgeNum);
            dataOffSet = dataOff; 
            reserved = Reserved;
            flags = flag;
            window =BitConverter.GetBytes(Window);
            checkSum =BitConverter.GetBytes(CheckSum);
            urgentPointer = BitConverter.GetBytes(Urgent);
            padding = BitConverter.GetBytes(Padding);
            

        }

        public byte[] createBinaryArray
        {
            get
            {
                return SourcePort;
            }
        }

        



        public void ConstructPacket(BitArray toBeConverted)
        {

            byte[] arr = new byte[toBeConverted.Length];
            toBeConverted.CopyTo(arr,0);
        }

    }
}
