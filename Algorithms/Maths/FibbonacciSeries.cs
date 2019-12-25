using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Maths
{
    class FibbonacciSeries
    {
        public void FibSeries()
        {
            int a = 0, b = 1, sum=0;

            for(int k=0; k < 10; k++)
            {

                Console.WriteLine(a);
                sum = a + b;
                a = b;
                b = sum;
            }
            
        }
    }
}
