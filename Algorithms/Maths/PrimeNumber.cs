using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Maths
{
    class PrimeNumber
    { 
        public void IsPrime()
        {
            int k = 2;
            int f = 0;

            for (int i = 1; i < k / 2+1; i++)
            {
                
                if (k % i == 0)
                {
                    f++;
                }
            }

            if (f < 2)
                Console.WriteLine("The given number is a prime");
            else
                Console.WriteLine("The given number is not a prime");
        }

        public void PrimeSeries()
        {
          
            for (int j=1; j<100; j++)
            {
                int f = 0;
                for (int i = 1; i < j / 2+1; i++)
                {
                    if (j % i == 0)
                    {
                        f++;
                    }

                }
                if (f < 2)
                {
                    Console.Write(j + ",");
                }

            }
        }
    }
}
