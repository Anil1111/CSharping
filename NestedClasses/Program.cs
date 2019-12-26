using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.AMethod();

            A.B ab = new A.B();
            ab.BMethod();

            A.B.C abc = new A.B.C();
            abc.CMethod();

            Console.ReadLine();
        }
    }
}
