using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class TypeConversion
    {
        //This called Boxing and Unboxing
        //You cannot cast datatype in class 
        //you can only perform casting in methods
        public void ExplicitMethod()
        {
            //Explicit type casting is UnBoxing
            //Explicit Type Casting
            int i = 10;
            long l= (int)i;
            Console.WriteLine("The implicit conversion from int to long " + l);
            double d = Convert.ToDouble(i);
            Console.WriteLine("The explicit conversion from int to double " + d);
            //double d1 = Convert.ToDouble(i);
            string str = "I am Kanna Reddy";
            char[] c = str.ToCharArray();
            foreach (char k in c) Console.WriteLine(k);
            
        }

        
        public void ImplictMethod()
        {
            //Implicit type casting is Boxing
            //Implicit Type Casting
            int i = 10;
            long l = i;
            double d = l;
            Console.WriteLine("The implicit conversion from int to long "+ l);
            Console.WriteLine("The implicit conversion from long to double " + d);
            //double d1 = Convert.ToDouble(i);
            //This called Boxing and Unboxing
        }


    }
}
