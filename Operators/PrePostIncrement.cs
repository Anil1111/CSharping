using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class PrePostIncrement
    {
        public void PrePostIncrementMedthod()
        {
            int k=1;
            int i = k, j = k;
            int x, y;

            while (k <= 10)
            {
                Console.WriteLine("Loop count k Value is  =" + k);
                x = i++; //after assigning i value to x then i increments by value 1
                Console.WriteLine("Post Increment x Value is  =" + x);
                y = ++j; //j increments first by value 1 then it assigns to y
                Console.WriteLine("Pre Increment y Value is  =" + y);

                k += 1; //k=k+1
                i = k;
                j = k;

            }
        }

    }
}
