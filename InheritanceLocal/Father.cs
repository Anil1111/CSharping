using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLocal
{
     class Father:GrandFather
    {
        internal double RectanglePerimeter
        {
            get
            {
                return 2 * (Length + Breadth);
            }
            set
            {
                RectanglePerimeter = value;
            }
        }
        
    }
}
