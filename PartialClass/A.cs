using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
   partial class A
    {
        int k = 20;

        public void AMethod()
        {
            Console.WriteLine("Printed from Class A of AMethod");
        }
    }
}
