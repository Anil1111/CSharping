using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControls
{
    class ForeachLoop
    {
        public void ForeachMethod()
        {
            int[] a = { 10, 20, 30, 40, 50, 60 };
            foreach(int i in a)
            {
                Console.WriteLine("Print foreach loop" + a.Length);
                Console.WriteLine("The a array values are: {0}", i);
                Console.WriteLine("The a array values are: {0}",a);
            }
        }
    }
}
