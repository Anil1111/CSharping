using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class ParametrizedConstructor
    {
        public ParametrizedConstructor(int ID, string Name) //Parametrized Constructor and takes arguments
        {
            Console.WriteLine("This message is being printed from ParametrizedConstructor");
            Console.WriteLine("ID" + "\t" + ID);
            Console.WriteLine("Name" + "\t" + Name);

            this.StaticConstructorMethod(ID,Name);
        }

        public void StaticConstructorMethod(int ID, string Name)
        {
            Console.WriteLine("This message is being printed from ParametrizedConstructorMethod");
            Console.WriteLine("ID" + "\t" + ID);
            Console.WriteLine("Name" + "\t" + Name);

        }
    }
}
