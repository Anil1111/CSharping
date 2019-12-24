using System;
using System.Collections; //this is mandatory for non-generic Collections
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    //https://www.tutorialsteacher.com/csharp/csharp-hashtable
    class HashtablesClass
    {
        public void HashtablesMethod()
        {
            Hashtable hashTable1 = new Hashtable();

            hashTable1.Add(1, "One");
            hashTable1.Add(2, "Two");
            hashTable1.Add(3, "Three");
            hashTable1.Add(4, "Four");
            hashTable1.Add(5, null);
            hashTable1.Add("Fv", "Five");
            hashTable1.Add(8.5F, 8.5);

            Hashtable hashTable2 = new Hashtable(){{ 1, "One" },{ 2, "Two" },{ 3, "Three" },{ 4, "Four" },{ 5, null },{ "Fv", "Five" },{ 8.5F, 8.5 }};

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable hashTable3 = new Hashtable(hashTable2);

            foreach (DictionaryEntry item in hashTable3)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);


            foreach (var key in hashTable3.Keys)
                Console.WriteLine("Key:{0}, Value:{1}", key, hashTable3[key]);

            Console.WriteLine("***All Values***");

            foreach (var value in hashTable3.Values)
                Console.WriteLine("Value:{0}", value);
        }
    }
}
