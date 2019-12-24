using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class  A<T>
    {
        public void AMethod(T k)  //Arguments or parameters are necessary to use the variables with Genertic Types
        {
            unsafe
            {
                Console.WriteLine($"Generic A Class from AMethod Type of T is {typeof(T)}, Size of Type k is {sizeof(int)} and k value is: {k}");
            }
            
        }
    }

    class B<T, D>
    {
        public B()
        {
            Console.WriteLine("This is printed from Class B of Constructor B ");
        }
        public void BMethod(T y, D z)
        {
            Console.WriteLine("This is printed from Class B of Method BMethod: " + y + " " + z);
        }
    }

    class C<T, D, H>
    {
        public C()
        {
            Console.WriteLine("This is printed from constructor of Class C");
        }
        public C(T i, D j, H k)
        {
            Console.WriteLine("This is printed from parameterized constructor of Class C: " + i + "  " + j + "  " + k);
        }
        public void CMethod(T x, D y, H z)
        {
            Console.WriteLine("This is printed from class C of CMethod: x={0}, y={1}, z={2}", x, y, z);
        }
    }
}
