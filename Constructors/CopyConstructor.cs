using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class CopyConstructor
    {
        public CopyConstructor(CopyConstructor copyConstructor)
        {
            ID = copyConstructor.ID;
            Name = copyConstructor.Name;
            copyConstructor.CopyConstructorMethod(ID, Name);
        }
        public CopyConstructor(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
            this.CopyConstructorMethod(this.ID, this.Name);
        }

        int ID;
        string Name;

        public void CopyConstructorMethod(int ID, string Name)
        {
            Console.WriteLine("Below Information printed from CopyConstructorMethod located in CopyConstructor Class");
            Console.WriteLine("ID" + "\t" + ID);
            Console.WriteLine("Name" + "\t" + Name);
        }
    }
}
