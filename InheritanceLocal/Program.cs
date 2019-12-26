using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InheritanceLocal.VirtualKeyword;  //Mandatory

namespace InheritanceLocal
{
    class Program
    {
        static void Main(string[] args)
        {
            //B b = new B();
            //b.AMethod();
            A a = new A();
            a.AMethod();


            //Drawing drawing = new Drawing();
            //drawing.Draw();


            //GrandChild grandchild = new GrandChild();
            //grandchild.Radius = 5.0;
            //grandchild.Length = 10;
            //grandchild.Breadth = 20;
            //grandchild.Height = 9;
            //Console.WriteLine(grandchild.RectangleArea);
            //Console.WriteLine(grandchild.RectanglePerimeter);
            //Console.WriteLine(grandchild.CircleArea);
            //Console.WriteLine(grandchild.TriangleArea);

            //Child child = new Child();
            //child.Radius = 5.0;
            //child.Length = 10;
            //child.Breadth = 20;
            //Console.WriteLine(child.Area);
            //Console.WriteLine(child.Perimeter);


            //Father father = new Father();
            //father.Length = 30;
            //father.Breadth = 50;
            //Console.WriteLine(father.Area);
            //Console.WriteLine(father.Perimeter);

            //GrandFather grandFather = new GrandFather();
            //grandFather.Breadth = 30;
            //grandFather.Length = 80;
            //Console.WriteLine(grandFather.Area);

            Console.ReadLine();

        }
    }
}
