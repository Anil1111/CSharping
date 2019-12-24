using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Triangle
    {
        public double Area(double Breadth, double Height)
        {
            return 0.5*Breadth * Height;
        }
        public double Perimeter(double a, double b, double c)
        {
            return  a+b+c;
        }
    }
}
