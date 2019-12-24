using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
  partial  class A
    {
        public void BMethod()
        {
            Console.WriteLine("This message is printed from Class A of B Method whic is partial");
        }
    }
}
