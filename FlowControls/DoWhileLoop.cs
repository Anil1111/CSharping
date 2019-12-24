using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControls
{
    class DoWhileLoop
    {
        int a, b, c;

        public void DoWhileLoopMethod()
        {
            a = 104;
            b = 15;

            do
            {
                c = a;
                a = b;
                b = c;

                Console.WriteLine("The Value of a={0}, b={0}", a, b);
                
            }
            while (a < b);

            Console.WriteLine("The values are not swapped");
        }
        
    }
}
