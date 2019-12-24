using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Rectangle : IShape
    {
        public double Area(double Length, double Breadth)
        {
            return Length*Breadth;
        }
        public double Perimeter(double Length, double Breadth)
        {

            return 2*(Length+Breadth);
        }

    }
}
