using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Maths
{
    class Evens
    {
        public void IsEven()
        {
            double k = 17;

            if (k % 2 == 0)
                Console.WriteLine("The Number is Even");
            else
                Console.WriteLine("The Number is Not Even");
        }
        public void EvenNumbers()
        {
            for(int k=0; k<10;k=k+2)
                Console.WriteLine(k);
        }
    }
}
