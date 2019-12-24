using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLocal
{
    class GrandChild:Child
    { 
        double h=0;
        internal double Height
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }
        internal double TriangleArea
        {
            get
            {
                return 0.5 * Breadth * Height;  // the value 1/2 implies 0 and total value will be 0
            }
            set
            {
                TriangleArea = value;
            }
        }
    }
}
