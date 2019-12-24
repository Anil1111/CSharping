using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControls
{
    class Forloop
    {
        public void ForLoopMethod()
        {
            int a = 1;
            for(int i = a; i < 10; i++)
            {
                if (i == 4)
                continue; //For loop no. 5, the remaining statements in the loop are not executed, i.e. skips

                Console.WriteLine("For loop is printing  "+i);
            }
        }
    }
}
