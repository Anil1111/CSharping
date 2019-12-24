using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //A a = new A();  //Compilation error, you cannot create object for abstract class
            //a.AMethod();
            //a.BMethod();

            C c = new C();
            c.AMethod();
            c.BMethod();
            c.CMethod();

            Console.ReadLine();
        }
    }
}
