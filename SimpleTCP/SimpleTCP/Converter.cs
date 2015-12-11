using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleTCP
{
 
    public static class Converter
    {
        public static byte[] BoolArrTObyteArr(bool[] boolArray)
        {
            BitArray bits = new BitArray(boolArray);
            byte[] flags = new byte[Math.Max(1, bits.Length / 8)];
            bits.CopyTo(flags, 0);
            return flags;

        }

        public static byte[] BitToByteArr(BitArray bitArray)
        {
            byte[] arr = new byte[Math.Max(1, bitArray.Length / 8)];
            bitArray.CopyTo(arr,0);
            return arr;
        }
        
    }
}
