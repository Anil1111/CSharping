using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IShape
    {
         double Area(double Length, double Breadth);
         double Perimeter(double Length, double Breadth);
    }
    
}
