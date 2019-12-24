using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class SimpleClass
    {
        int x = 20;
        public SimpleClass()
        {
            Console.WriteLine("Constructor in Simple Class is invoked  "+x);
        }
        public void SimpleClassMethod()
        {
            int k = 10;
        }
    }
    class GenericClass<T>
    {

    }

    struct GenericStructure<T>
    {

    }
}
