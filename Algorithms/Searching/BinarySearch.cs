using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    class BinarySearch
    {
        public void BinarySearching()
        {
            int[] bsa = { 11, 34, 67, 36, 78, 22, 14, 97, 19 };
            int result = 0;
            for (int k = 0; k < bsa.Length; k++)
            {
                if (bsa[k] == 300)
                    result = 1;
                else
                    result = -1;

            }
            if (result == 1)
            {
                Console.WriteLine("The Item is found");
            }
            else if (result == -1)
            {
                Console.WriteLine("The Search Item is not found");
            }

        }
    }
}
