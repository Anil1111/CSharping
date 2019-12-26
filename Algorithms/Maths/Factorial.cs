using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Maths
{
    class Factorial
    {
        public void FactorialN()
        {
            int i=8,j = 1;
            for(; i > 1; i--)
            {
                j = i * j;
            }

            Console.WriteLine(j);
            Console.WriteLine(FactorialRecursion(8));
        }

        public int FactorialRecursion(int i)
        {
            if (i <= 1)
            return 1;
            
            else
            return i* FactorialRecursion(--i);  //i++ does not work

        }
    }
}
