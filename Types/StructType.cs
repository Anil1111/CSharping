using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    struct StructType
    {
        static string s = "The structure is same as structure in C Language";
        public void StructTypeMethod()
        {
            int a = 4, b = 8;
            b = a + b;
            Console.WriteLine("The int b=a+b is: {0}\nThe static string value from struct is: {1} ", b, s);
        }
    }
}
