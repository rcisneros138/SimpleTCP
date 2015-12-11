using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleTCP
{
 
    class Converter
    {
        byte[] dataOff;
        byte[] reserved;
        byte[] flags;

        public void BoolArrTObyteArr(bool[] boolArray)
        {
            BitArray bits = new BitArray(boolArray);  
            flags = new byte[Math.Max(1,bits.Length/8)];
            bits.CopyTo(flags, 0);

            
       
        }
    }
}
