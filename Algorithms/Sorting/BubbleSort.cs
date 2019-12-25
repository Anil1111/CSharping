using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class BubbleSort
    {
        public void Sort()
        {
            int[] a = { 11, 34, 67, 36, 78, 22, 14, 97, 19 };
            
            int tmp;
            for (int i = 0; i < a.Length; i++)
            {   // loop n times - 1 per element
                for (int j = 0; j < a.Length-i- 1; j++)
                { // last i elements are sorted already
                    if (a[j] > a[j + 1])
                    {  // swop if order is broken
                        tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
                
            }
            foreach(int k in a)
            Console.WriteLine(k);
        }
    }
}
