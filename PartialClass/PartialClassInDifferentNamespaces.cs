using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass2
{
    partial class A
    {
        public void CMethod()
        {
            Console.WriteLine("Partial classe added a CMethod() in different namespace");
        }
    }
}
