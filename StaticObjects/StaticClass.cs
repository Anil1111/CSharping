using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class A
    {
        public static void AMethod()  //Method Should also static in Static class since it stired in heap and no instances are supported
        {
            const int k= 10;
            // k = k + 1;  // compilation error
            Console.WriteLine("This is printed from Static A Class of static AMethod  "+k);  //No object creation is entertained
        }
    }
}
