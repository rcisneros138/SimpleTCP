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
        public object originalObj;
        public Translator(T input)
        {
            if (input == null)
            {
                Console.WriteLine("null");
            }
            
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memStream = new MemoryStream())
            {
                formatter.Serialize(memStream, input);
                ArrayBytes = memStream.ToArray();
                //Console.WriteLine(Encoding.Default.GetString(ArrayBytes));
                //Console.ReadLine();
                convertToObject(ArrayBytes);
            }
            
        }
        public void  convertToObject(byte[] array)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            memStream.Write(array, 0, array.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)formatter.Deserialize(memStream);
            originalObj = obj;
            Console.WriteLine(originalObj);
            Console.ReadLine();

            
        }
    }
}
