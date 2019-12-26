using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Maths
{
    class Odds
    {
        public void IsOdd()
        {
            double k = 17;

            if (k % 2 != 0)
                Console.WriteLine("The Number is Odd");
            else
                Console.WriteLine("The Number is Not Odd");
        }
        public void OddNumbers()
        {
            for (int k = 1; k < 10; k = k + 2)
                Console.WriteLine(k);
        }
    }
}
