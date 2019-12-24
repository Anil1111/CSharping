using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateClass
{
    class C
    {
        public delegate void BDelegate(int k);

        public void AMethod()
        {
            BDelegate bDelegate = new BDelegate(BMethod);

            Console.WriteLine("This is printed from AMethod()");
            bDelegate.Invoke(199);
            bDelegate(100);
           
        }

        public void BMethod(int k)
        {
            Console.WriteLine("This is Printed from BMethod: "+k);
           
        }

    }
}
