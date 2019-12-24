using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction 
{ 
   abstract class A  //Compilation error with a abstract method, abstract keyword is mandatory
    {
        public abstract void BMethod();//Compilation error when you don't use abstract keyword for undefined method
        public void AMethod()
        {
            Console.WriteLine("This is printed from BMethod");
        }
    }

    class C : A
    {
        public override void BMethod()  //Compilation error with a abstract method implementation, override keyword is mandatory
        {
            Console.WriteLine("This printed from inherited BMethod from A Class");
        }
        public void CMethod()
        {
            Console.WriteLine("This is printed from CMethod");
        }
    }
}
