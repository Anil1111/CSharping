using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{   //https://www.c-sharpcorner.com/UploadFile/0c1bb2/constructors-and-its-types-in-C-Sharp/
    /*
     * A static constructor does not take access modifiers or have parameters.
      * A static constructor is called automatically to initialize the class before the first instance is created or any static members are referenced.
      * A static constructor cannot be called directly.
      * The user has no control on when the static constructor is executed in the program.
      * A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.
     */
    class StaticConstructor
    {
        static StaticConstructor()  //no modifier accepted and No parameters accepeted
        {
            Console.WriteLine("This message is printed from StaticConstructor");
            //this.StaticConstructorMethod()  //does not work
            //StaticConstructor.StaticConstructorMethod(); //does not work
        }

        int ID;
        string Name;

        public void StaticConstructorMethod()
        {
            Console.WriteLine("This message is being printed from StaticConstructorMethod");
            Console.WriteLine("ID" + "\t" + ID);
            Console.WriteLine("Name" + "\t" + Name);

        }
    }
}
