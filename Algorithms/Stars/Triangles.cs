using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Stars
{
    class SemiTriangle
    {
        public void SemiTriangleStar()
        {
            for(int i=1; i<15; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }

        public void NumberTriangle()
        {
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
        }
    }
}
