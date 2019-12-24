using System;
using InheritanceLocal;
using InheritanceRemote;
namespace InheritanceLocal
{
    class Drawing: InheritanceRemote.Rectangle
    {
        public void Draw()
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.Area(30, 50));

            Circle circle = new Circle();
            Console.WriteLine(circle.Area(6));
        }
    }
}
