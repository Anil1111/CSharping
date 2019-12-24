using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControls
{
    class WhileLoop
    {
        public void Whileloopmethod()
        {
            int a = 1;

            while (a < 10)
            {
                a++;

                if (a == 7)
                    goto mycustomelabelname; //for a==4, jumps away from loop and a specific code set will be executed
                Console.WriteLine("WhileLoop Running  "+a);
            }
        mycustomelabelname:
            {
                Console.WriteLine("Code ran away from while loop at a=" + a);
            }

            
        }

    }
}
