using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLocal
{
    class Child:Father
    {
        double r = 0;
        internal double Radius
        {
            get
            {
                return r;
            }
            set
            {
                r = value;  //Radius=value was thrown stackoverflow exception since Radius=Radius will occur
            }
        }
        internal new double CircleArea
        {
            get
            {
                return 3.14 * r;  //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/doubleing-point-numeric-types
            }
            set
            {
                CircleArea = value;
            }
        }
    }
}
