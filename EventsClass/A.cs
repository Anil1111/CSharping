using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsClass
{
    //BMethod is India, BDelegate is Indian Cricket Team, Event is the match to perform
    class A
    {
        private B b;

        public A()
        {
            b = new B();
            b.CEvent += AMethod;//event created
        }
        
        public void AMethod(int k)
        {
            Console.WriteLine("This message is printed from AMethod: "+k);
        }
        public void BMethod(int k)
        {
            Console.WriteLine("This message is printed from BMethod");
            b.DMethod(k);
        }
        public void CMethod(int k)
        {
            Console.WriteLine("This message is printed from CMethod");
        }

    }

    public class B
    {
        public delegate void CDelegate(int k);  // declare delegate 
        public event CDelegate CEvent;  //declare event of type delegate

        public void DMethod(int k)
        {
            if (CEvent != null)
                CEvent(898);
            Console.WriteLine("This message is printed from DMethod");
        }

        public void EMethod(int k)
        {
            Console.WriteLine("This message is printed from EMethod");
        }

        public void FMethod(int k)
        {
            Console.WriteLine("This message is printed from FMethod");
        }

        public void GMethod(int k)
        {
            Console.WriteLine("This message is printed from GMethod");
        }
    }
}
