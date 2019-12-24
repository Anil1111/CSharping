using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateClass
{
    class D
    {
        public delegate void CDelegate(int g);

        public void AMethod()
        {
            Console.WriteLine("This message is printed from AMethod");
            CDelegate cDelegate = new CDelegate(CMethod);
            BMethod(cDelegate);
        }

        public void BMethod(CDelegate k)
        {
            Console.WriteLine("This message is printed from BMethod");
            k(100);
            k.Invoke(200);
        }

        public void CMethod(int k)
        {
            Console.WriteLine("This message is printed from CMethod: "+k);
        }
    }
}
