using System;
using System.Collections; //this is mandatory for non-generic Collections
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    class ArrayListClass
    {
        public void ArrayListsMethod()
        {
            ArrayList arrayList1 = new ArrayList();// Recommended

            IList arrayList2 = new ArrayList() { 100, 200 };
            ICollection arrayList3 = new ArrayList() { 100, "Two", 12.5, 200 };
            IEnumerable arrayList4 = new ArrayList();

            arrayList1.Add(1);
            arrayList1.Add("Two");
            arrayList1.Add(3);
            arrayList1.Add(4.5);

            //Adding entire collection using ArrayList.AdRange() method.
            ////Note: IList does not contain AddRange() method.
            
            arrayList1.AddRange(arrayList2);


            arrayList1.Insert(1, "Top");
            arrayList1.InsertRange(3, arrayList3);

            arrayList1.Remove(3);
            arrayList1.RemoveAt(2);
            arrayList1.RemoveRange(3, 4);
            //arrayList1.Reverse();

            foreach (var i in arrayList1)
                Console.WriteLine(i);

            Console.WriteLine(arrayList1.Contains(200));
        }


    }
}
