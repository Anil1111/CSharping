using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedMethods
{
    class A
    {
        public void AMethod()
        {

            void AMethod1()
            {
                void AMethod2()
                {
                    Console.WriteLine("This method is printed from AMethod2()");
                }

                Console.WriteLine("This method is printed from AMethod1()");
            }

            Console.WriteLine("The message is prited from AMethod of Class A");
        }
    }
}
