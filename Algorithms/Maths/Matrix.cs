using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Maths
{
    class Matrix
    {
        public void MatrixAddition()
        {
            int[,] a = new int[3,3] { { 1, 2, 3}, { 1, 2, 3}, { 1, 2,3} };
            int[,] b = new int[3, 3] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };

            int[,] c = new int[3, 3];

            for (int i=0; i <= 2; i++){
                Console.Write("{");
                for (int j = 0; j <= 2; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write(c[i, j]+" ");
                }
                Console.Write("},");
            }

        }

        public void MatrixMultiplication()
        {
            int[,] x= { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] y = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            int[,] z = new int[3, 3];

            for(int i=0; i<=2; i++)
            {
                for(int j=0; j<=2; j++)
                {
                    z[i, j] = (x[i, j] * y[i, 0])  + (x[i,j]*y[i, 1]) +  (x[i, j]*y[i,2]);
                    Console.Write(z[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
