using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    public class A
    {
        public class B
        {
           public class C
            {
                public void CMethod()
                {
                    Console.WriteLine("This is Printed from Class C, Which is in Class B, That is in Class C");
                }
            }
            public void BMethod()
            {
                Console.WriteLine("This is printed from Class B, which is in Class A");
            }
        }
        public void AMethod()
        {
            Console.WriteLine("This is printed from class A");
        }
    }
}
