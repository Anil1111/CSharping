using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControls
{
    class IfElse
    {
        public void IfElseMethod()
        {
            int x = 3;
            int y = 49;
            int z = -5;

            if (x < y)
            {
                Console.WriteLine("if condtion is true");
            }
            else if (y < z)
            {
                Console.WriteLine("else if condition is true");
            }
            else
            {
                Console.WriteLine("else final condition was executed");
            }
        }
    }
}
