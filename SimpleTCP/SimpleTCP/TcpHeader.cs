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
        byte[] dataOffSet;
        byte[] reserved;
        byte[] flags;
        byte[] window;
        byte[] checkSum;
        byte[] urgentPointer;
        byte[] padding;
        byte[] finalArray;





        public TcpHeader(short sourcePort, short destinationPort, int sequencePort, int acknowledgeNum, BitArray dataOff, BitArray Reserved, bool[] flag, short Window, short CheckSum, short Urgent, int Padding)
        {
            //SourcePort = new BitArray(BitConverter.GetBytes(sourcePort));
            SourcePort =  BitConverter.GetBytes(sourcePort);
            DestinationPort = BitConverter.GetBytes(destinationPort);
            SequencePort = BitConverter.GetBytes(sequencePort);
            acknowlegementNumber = BitConverter.GetBytes(acknowledgeNum);
            dataOffSet = Converter.BitToByteArr(dataOff); 
            reserved = Converter.BitToByteArr(Reserved);
            flags = Converter.BoolArrTObyteArr(flag);
            window =BitConverter.GetBytes(Window);
            checkSum =BitConverter.GetBytes(CheckSum);
            urgentPointer = BitConverter.GetBytes(Urgent);
            padding = BitConverter.GetBytes(Padding);
            

        }

        public byte[] binaryArray
        {
            get {
                
                SourcePort.CopyTo(finalArray, 0);
                DestinationPort.CopyTo(finalArray,SourcePort.Length);
                SequencePort.CopyTo(finalArray, DestinationPort.Length);
                acknowlegementNumber.CopyTo(finalArray, SequencePort.Length);
                dataOffSet.CopyTo(finalArray, acknowlegementNumber.Length);
                reserved.CopyTo(finalArray,dataOffSet.Length);
                flags.CopyTo(finalArray, reserved.Length);
                window.CopyTo(finalArray, flags.Length);
                checkSum.CopyTo(finalArray, window.Length);
                urgentPointer.CopyTo(finalArray, checkSum.Length);
                padding.CopyTo(finalArray, urgentPointer.Length);

                  return finalArray;}
            
            
         
        }

        



        

    }
}
