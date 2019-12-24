using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateClass
{   //delegates are used for callback, feedback, response
    //in straight words giving alias name to a method
    //BMethod is India, BDelegate is Indian Cricket Team
    class A
    {
        public delegate void BDelegate(int value); //Its just like new object dec;aration like int, float, string, char

        public void AMethod()
        {
            BDelegate bDelegate = new BDelegate(BMethod);  //Delegate object instantation 
            bDelegate(911);

            Console.WriteLine("This is printed from ");
        }

        public void BMethod(int k)
        {
            Console.WriteLine("Hello Delegate: "+k);
        }

    }
}
