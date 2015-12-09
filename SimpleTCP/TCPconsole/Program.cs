using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;

namespace TCPconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            Translator<object> translator = new Translator<object>(testClass);

            
        }
    }
}
