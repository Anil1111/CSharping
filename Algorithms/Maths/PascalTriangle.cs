using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Maths
{
    class PascalTriangles
    {
        public void PascalTriangle()
        {
            for(int i=1; i<10; i++)
            {
                for(int j=1; j<i; j++)
                {
                    Console.Write(j+" ");

                        for(int k=1; k<j; k++)
                            Console.Write(k+j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
