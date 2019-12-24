using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{   //https://www.c-sharpcorner.com/UploadFile/0c1bb2/constructors-and-its-types-in-C-Sharp/
    /*One use of a private constructor is when we have only static members.
    *It provides an implementation of a singleton class pattern
    *Once we provide a constructor that is either private or public or any, the compiler will not add the parameter-less public constructor to the class.
    */
    class PrivateConstructor
    {
        private PrivateConstructor()
        {
            Console.WriteLine("This message is printed from PrivateConstructor");
        }
        static int ID = 10;  //static modifier is necessary for initilizing object to PrivateConstructor i.e. instantiation
        static string Name = "Kanna Reddy";
        static public void PrivateConstructorMethod()
        {
            Console.WriteLine("This message is being printed from PrivateConstructor");
            Console.WriteLine("ID" + "\t" + ID);
            Console.WriteLine("Name" + "\t" + Name);
        }
    }
}
