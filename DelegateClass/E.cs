using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateClass
{
    class E
    {
        public delegate void DDelegate(int g);

        public void AMethod()
        {
            Console.WriteLine("This message is printed from AMethod");
            DDelegate dDelegate = new DDelegate(CMethod);
                dDelegate += new DDelegate(DMethod);
                dDelegate += new DDelegate(EMethod);
            dDelegate += new DDelegate(FMethod);
            dDelegate -= new DDelegate(FMethod);
            BMethod(dDelegate);

        }

        public void BMethod(DDelegate k)
        {
            Console.WriteLine("This message is printed from BMethod");
            k(100);
            //k.Invoke(200);
        }

        public void CMethod(int k)
        {
            Console.WriteLine("This message is printed from CMethod: " + k++);
        }

        public void DMethod(int k)
        {
            Console.WriteLine("This message is printed from DMethod: "+ k++);
        }

        public void EMethod(int k)
        {
            Console.WriteLine("This message is printed from EMethod "+ k++);
        }
        public void FMethod(int k)
        {
            Console.WriteLine("This message is printed from FMethod " + k++);
        }
    }
}
