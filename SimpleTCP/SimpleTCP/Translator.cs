using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SimpleTCP
{
    public class Translator<T>
    {
        public byte[] ArrayBytes;
        public Translator(T input)
        {

            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memStream = new MemoryStream())
            {
                formatter.Serialize(memStream, input);
                ArrayBytes = memStream.ToArray();
            }
        }
    }
}
