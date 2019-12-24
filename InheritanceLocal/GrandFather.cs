using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLocal
{
     class GrandFather
    {
        double l = 0, b = 0;
        //l=>length, b=>breadth, a=>area, p=>perimeter, d=>diagnol
        internal double Length
        {
            get
            {
                return l;
            }
            set
            {
                l = value;
            }
        }
        internal double Breadth
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        internal double RectangleArea
        {
            get
            {
                return l * b;
            }
            set
            {
                RectangleArea = value;
            }
        }

    }

}
