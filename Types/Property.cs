using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    //Very Important ***Property will replace unnecessary methods which are just for arithmetic calculations that return value e.g area of rectangle
    //CLR Property
    //Property is directly member of class and methods does not accept property
    //The crucial difference between them is that a variable represents a memory location but a property does not
    //Property is also variable and will allow changes/updates to it in runtime
    //encapsulation is a wrapping of data provided by methods and properties
    //private variables can be accessed ONLY by methods and properies of that class i.e. encapsulation
    //Properties allow data swaping b/w variables and properties at runtime initilization
    //Property is also primitve datatype with declaration, without initialization
    //Property is also a variable
    //get set works for cross properties i.e. one property can set the values of other property
    //Reference https://www.c-sharpcorner.com/forums/difference-between-a-property-and-variable

    class Rectangle
    {
        private int l = 0, b = 0;
        /*default values, when no values are passed to variables or properties when object was created
         *Let the above variable be private, outside classes cannot access the variable l and b, then properties will help for outside classes
         */
        public int Length
        {
            get
            {
                return l;
            }
            set  //Apply modifier Private, protected as prefix to set
            {
                l = value;
            }
        }
        public int Breadth
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
        public int Area
        {
            get
            {
                return Length * Breadth;
            }
            set
            {
                Area = value;
            }
        }

        public int RectangleAreaVariableMethod()
        {
            return Length * Breadth;
        }
        public int RectangleAreaPropertyMethod()
        {
            return Area;
        }
        public int RectangleAreaParameterMethod(int Length, int Breadth)
        {
            return Length * Breadth;
        }
    }
    class Drawings
    {
        public void DrawMethod()
        {
            Rectangle recobj = new Rectangle
            {
                Length = 30,
                Breadth = 20
            };
            //recobj.Length = 30;  //Accepted
            //recobj.Breadth = 20; //Accepted
            //Console.WriteLine(recobj.l); //remove private access specifier for variable l to print
            //Console.WriteLine(recobj.b); //remove private access specifier for variable b to print
            Console.WriteLine(recobj.Length);
            Console.WriteLine(recobj.Breadth);
            Console.WriteLine(recobj.Area);
            Console.WriteLine(recobj.RectangleAreaVariableMethod());
            Console.WriteLine(recobj.RectangleAreaPropertyMethod());
            Console.WriteLine(recobj.RectangleAreaParameterMethod(recobj.Length, recobj.Breadth));
        }
    }
}
