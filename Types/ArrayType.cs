using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class ArrayType
    {
        public void ArraysMethod()
        {
            int[] si1 = { 1, 2, 3, 4, 5, 6 };
            int[,] by2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            foreach (int k in si1) Console.WriteLine(k);
            Console.WriteLine("\n");
            foreach (int k in by2) Console.WriteLine(k);

            int[] intArray = new int[5];
            intArray[0] = 10;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;

            int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };

            _ = new int[5] { 1, 2, 3, 4, 5 };

            int[,] intArrayby2 = new int[3, 2]{ {1, 2},{3, 4},{5, 6} };

            int[][] intJaggedArray = new int[2][];
            intJaggedArray[0] = new int[3] { 1, 2, 3 };
            intJaggedArray[1] = new int[2] { 4, 5 };

        }

    }
}
