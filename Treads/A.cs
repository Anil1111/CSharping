using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;  //Manadatory use/import of this statement
using System.Threading.Tasks;

namespace Treads
{
    class A
    {

        public void AMethod()
        {
            int milliSeconds = 1000;
            Console.WriteLine("Wait for "+milliSeconds+" milli seconds the message is being printed");
            Thread.Sleep(10000);
            Console.WriteLine("This message is printed AMethod");
        }
    }
}
