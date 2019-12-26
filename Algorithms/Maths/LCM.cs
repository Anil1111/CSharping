using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Maths
{
    class LCM
    {
        public void LCMValue()
        {
            //2, 4, 

            int x=7, y=5;

            for(int i=1; i<x*y; i++)
            {
                if (x == y)
                {
                    Console.WriteLine("The LCM is ="+x);
                    break;
                }
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }

        }
    }
}
