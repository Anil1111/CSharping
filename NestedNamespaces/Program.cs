using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    namespace Second
    {
        class SecondClass
        {
            //Everything about namespaces has been tested here
            //All operations related to namespaces are taken here
            static void Main(string[] args)
            {
                //Fifth.Sixth.SixthClass sixthClass = new Fifth.Sixth.SixthClass();
                //sixthClass.SixthClassMethod();
                //Fifth.FifthClass fifthClass = new Fifth.FifthClass();
                //fifthClass.FifthClassMethod();
                //Third.Fourth.FourthClass fourthClass = new Third.Fourth.FourthClass();
                //fourthClass.FourthClassMethod();
                //Third.ThirdClass thirdClass = new Third.ThirdClass();
                //thirdClass.ThirdClassMethod();
                //FirstClass firstClass = new FirstClass();
                //firstClass.FirstClassMethod();
                Console.WriteLine("This is printed from Main method, which starts the execution in Second Class of nested Second namespace Second in First");
                Console.ReadLine();
            }

        }
    }

    namespace Third
    {
        namespace Fourth
        {
            class FourthClass
            {
                public void FourthClassMethod()
                {
                    Console.WriteLine("This message is printed from FourthClass method of Fouth class which is located in Fourth Namespace and which is loacted in third namespace that is loacted in first namespace");
                }
            }
        }
        class ThirdClass
        {
            public void ThirdClassMethod()
            {
                Console.WriteLine("This message is printed from ThirdClass method of thirdclass of third namespace of firstnamespace");
            }
        }
    }

    class FirstClass
    {
        public void FirstClassMethod()
        {
            Console.WriteLine("This is printed from FirstClass method of AClass of Namespace A");
        }
    }


}

namespace Fifth
{
    namespace Sixth
    {
        class SixthClass
        {
            public void SixthClassMethod()
            {
                Console.WriteLine("This Message is printed from SixthClassMethod of SixthClass of Sixth Namespace which is nested in Fifth namespace");
            }
        }
    }
    class FifthClass
    {
        public void FifthClassMethod()
        {
            Console.WriteLine("This message is printed from FifthClassMethod of FifthClass of Fifh Namespace");
        }
    }
}