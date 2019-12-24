using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A = System.Console;  //Macro

namespace StartUpProject
{
    class MacrosClass
    {
        readonly int i = 80;
        public void MacroMethod()
        {
            A.WriteLine(i);
        }
    }
}
