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
        public TcpHeader(int sourcePort, int destinationPort, int sequencePort, int acknowledgeNum, int dataOff, int rev, bool[] Flags, int Window, int CheckSum, int Urgent, int options, int Padding, int TcpData)
        {
            BitArray SourcePort = new BitArray(BitConverter.GetBytes(sourcePort));
            BitArray DestinationPort = new BitArray(BitConverter.GetBytes(destinationPort));
            BitArray SequencePort = new BitArray(BitConverter.GetBytes(sequencePort));
            BitArray acknowlegementNumber = new BitArray(BitConverter.GetBytes(acknowledgeNum));
            BitArray dataOffset = new BitArray(BitConverter.GetBytes(dataOff));  //needs to be 4 bits
            BitArray reversed = new BitArray(BitConverter.GetBytes(rev)); //needs to be 6 bits 
            BitArray flags = new BitArray(Flags);
            BitArray window = new BitArray(BitConverter.GetBytes(Window));
            BitArray checkSum = new BitArray (BitConverter.GetBytes(CheckSum));
            BitArray urgentPointer = new BitArray(BitConverter.GetBytes(Urgent));
            BitArray tcpOptions = new BitArray(BitConverter.GetBytes(options));
            BitArray padding = new BitArray(BitConverter.GetBytes(Padding));
            BitArray tcpData = new BitArray(BitConverter.GetBytes(TcpData));

        }





        public static void ConstructPacket()
        {
            
        }

    }
}
