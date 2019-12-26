using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{ 
    class EscapeString
    {
       public void EscapeStringMethod()
       {
            //Console.WriteLine("A:\Repos\CSharp"); // not working to print
            //Console.WriteLine("""); // not working to print "
            //Console.WriteLine("\");// not working to print \

            Console.WriteLine("Escape Strings Check");

            Console.WriteLine("\n");
            Console.WriteLine("new line printed");

            Console.WriteLine("\r");
            Console.WriteLine("carriage returned");
            
            Console.WriteLine("\"");
            Console.WriteLine("Double Quote Printed");

            Console.WriteLine("\'");
            Console.WriteLine("Single Quote Printed");

            Console.WriteLine("\\");
            Console.WriteLine("Black Slashed printed");

            Console.WriteLine("//");
            Console.WriteLine("Forward Slashed printed");

            Console.WriteLine(@"The @ sign will be used for escaping strings which will consider first and last sentense as one string");
            Console.WriteLine(@"A:\Repos\CSharp");

            Console.WriteLine("\0");
            Console.WriteLine("The Unicode character 0 printed");

            Console.WriteLine("\a");
            Console.WriteLine("The Alert is printed");

            Console.WriteLine("\b");
            Console.WriteLine("The backspace is printed");

            Console.WriteLine("\f");
            Console.WriteLine("The Form feed is printed");

            Console.WriteLine("\t");
            Console.WriteLine("The Horizontal tab is printed");

            Console.WriteLine("\v");
            Console.WriteLine("The Vertical tab is printed");

        

            //Console.WriteLine("A:\Repos\CSharp"); // not working to print
            //Console.WriteLine("""); // not working to print "
            //Console.WriteLine("\");// not working to print \
        }
    }
}
