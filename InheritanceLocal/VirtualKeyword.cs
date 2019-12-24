using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLocal
{
    namespace VirtualKeyword
    {
        class A
        {
            public virtual void AMethod()
            {
                Console.WriteLine("AMethod in Base class");
            }
        }

        class B : A
        {
            public void BMethod()
            {
                Console.WriteLine("BMethod in Derived Class ");
            }

            public override void AMethod()
            {
                Console.WriteLine("AMethod in Derived class");
            }
        }
    }
    
}
