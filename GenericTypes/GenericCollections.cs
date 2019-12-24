using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    //https://www.tutorialsteacher.com/csharp/csharp-generic-collections
    class GenericCollections
    {
        public void GenericList()
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40 };
            IList<int> intList2 = new List<int>();
            intList2.Add(10);
            intList2.Add(20);
            intList2.Add(30);
            intList2.Add(40);

            IList<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("four");
            strList.Add(null);
            strList.Add(null);

            IList<Student> studentList = new List<Student>();
            studentList.Add(new Student() { ID=1, Name="Kanna"});
            studentList.Add(new Student());
            studentList.Add(new Student() { ID=5,Name="Raja"});
            studentList.Add(new Student());
            studentList.Add(new Student() { ID = 5, Name = "Chai" });

            foreach (Student vp in studentList)
                Console.WriteLine("ID: {0}, Name: {1}", vp.ID, vp.Name);  //Concerntrate how I am printing

            foreach (int vp in intList) //default index
                Console.WriteLine("value: {0}", vp);
            foreach (int vp in intList2) 
                Console.WriteLine("value: {0}", vp);
            foreach (string vp in strList) 
                Console.WriteLine("value: {0}", vp);
            
        }

        public void GenericDictionary()  //Dictionary cannot include duplicate or null keys, where as values can be duplicated or set as null. Keys must be unique otherwise it will throw a runtime exception.
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();
            Dictionary<int, string> dict2 = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            //dict2.Add(new KeyValuePair<int, string>(1, "One"));  //compilation error
            //dict2.Add(new KeyValuePair<int, string>(2, "Two"));  //compilation error

            //dict.Add(new KeyValuePair<int, string>(1, "One"));  //Runtime error, multiple keys are not accepted in dictionary collection
            //dict.Add(new KeyValuePair<int, string>(2, "Two")); //Runtime error, multiple keys are not accepted in dictionary collection

            foreach (KeyValuePair<int, string> kvp in dict)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            foreach (KeyValuePair<int, string> kvp in dict2)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }

        public void GenericSortedList()
        {
            SortedList<int, string> mySortedList = new SortedList<int, string>();
            SortedList<int, string> sortedList1 = new SortedList<int, string>();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");

            SortedList<string, int> sortedList2 = new SortedList<string, int>();
            sortedList2.Add("one", 1);
            sortedList2.Add("two", 2);
            sortedList2.Add("three", 3);
            sortedList2.Add("four", 4);
            // Compile time error: cannot convert from <null> to <int>
            // sortedList2.Add("Five", null);

            SortedList<double, int?> sortedList3 = new SortedList<double, int?>();
            sortedList3.Add(1.5, 100);
            sortedList3.Add(3.5, 200);
            sortedList3.Add(2.4, 300);
            sortedList3.Add(2.3, null);
            sortedList3.Add(1.1, null);

            foreach (KeyValuePair<int, string> kvp in sortedList1)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            foreach (KeyValuePair<string, int> kvp in sortedList2)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            foreach (KeyValuePair<double, int?> kvp in sortedList3)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }
    }

    class Student
    {
        public int ID;
        public string Name;
    }
}
