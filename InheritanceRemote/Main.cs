using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRemote
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.Area(30,50));

            Circle circle = new Circle();
            Console.WriteLine(circle.Area(6));

            Triangle triangle = new Triangle();
            Console.WriteLine(triangle.Area(4,5));
            Console.WriteLine(triangle.Perimeter(3, 4, 5));
    
            Console.ReadLine();
           
        }
    }
}
