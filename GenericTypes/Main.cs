using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class MainClass
    {
        static void Main(string[] args)
        {

            GenericCollections genericCollections = new GenericCollections();
            genericCollections.GenericList();
            //genericCollections.GenericDictionary();
            //genericCollections.GenericSortedList();

            //SimpleClass simpleClass = new SimpleClass();
            //GenericConstraints<SimpleClass> genericConstraints = new GenericConstraints<SimpleClass>(simpleClass);
            //genericConstraints.genericMethod(simpleClass);

            //GenericConstraints<int> genericConstraints = new GenericConstraints<int>();  //Compile Time Error
            //genericConstraints.genericMethod();

            //Generics2<string> generics21= new Generics2<string>("Kanna Reddy");
            //generics21.genericMethod("Mr Reddy");

            //Generics2<int> generics2 = new Generics2<int>(202);
            //generics2.genericMethod(20);

            //C<int, float, string> c1 = new C<int, float, string>(10, 20.20f, "ABC");
            //c1.CMethod(100, 200.20f, "XYZ");

            //C<int, float, string> c = new C<int, float, string>();
            //c.CMethod();

            //B<int, float> b = new B<int, float>();
            //b.BMethod(90, 30.98f);

            //A<int> a = new A<int>();
            //a.AMethod(20);

            Console.ReadLine();
        }
    }
}
