using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateClass
{
    class B
    {
        public void AMethod()
        {
            Console.WriteLine("This is from AMethod");
            BMethod();
        }

        public void BMethod()
        {
            Console.WriteLine("This is from BMethod");
            AMethod();
        }

    }
}
