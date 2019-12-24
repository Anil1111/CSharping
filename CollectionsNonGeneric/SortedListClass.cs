using System;
using System.Collections; //this is mandatory for non-generic Collections
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    class SortedListClass
    {
        public void SortedListMethod()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(1, 101);
            sortedList.Add(2, 102);
            sortedList.Add(3, 103);

            SortedList sortedList2 = new SortedList(){{3, "Three"},{4, "Four"},{1, "One"},{5, "Five"},{2, "Two"}};

            foreach (var i in sortedList)
                Console.WriteLine(i);

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}",
                    sortedList.GetKey(i), sortedList.GetByIndex(i));
            }

            for (int i = 0; i < sortedList2.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}",
                    sortedList2.GetKey(i), sortedList2.GetByIndex(i));
            }

            Console.WriteLine(sortedList.Capacity);
            Console.WriteLine(sortedList.Count);


        }
    }
}
