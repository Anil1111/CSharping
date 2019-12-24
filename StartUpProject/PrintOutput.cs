using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpProject
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
    class PrintOutput
    {
        //Use readonly attribute for only printing datatype values
        readonly int x = 101;
        readonly string s = "This is a string";
        readonly string es = @"A:\Repos\CSharp\";
        readonly char c = 'A';

        public void PrintOutputMethod()
        {

            Console.WriteLine(2+3);
            Console.WriteLine(!true);
            Console.WriteLine(PrintPassMethod());
            Console.WriteLine(x + s + es + c);
            Console.WriteLine("The DataType Values are:", x + s + es + c);
            Console.WriteLine(x + "  " + s + "  " + es + " " + c);
            Console.WriteLine("The DataType Values are: {0}, {1}, {2}, {3}");
            // Composite formatting:
            Console.WriteLine("The DataType Values are: {0}, {1}, {2}, {3}",x,s,es,c);
            Console.WriteLine("The DataType Values is: {0:C}", s); //**Please Refer**//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/formatting-numeric-results-table
            // String interpolation:
            Console.WriteLine($"The DataType Values are: {x}, {s}");
            Console.WriteLine(@"A:\Repos\CSharp\");


            //verbatim identifier
            //Using for even it is keyword by prefixing @ character
            string[] @for = { "Laddu", "Pandu", "Honey", "Sweety" };
            for (int ctr = 0; ctr < @for.Length; ctr++)
            {
                Console.WriteLine($"Here is your gift, {@for[ctr]}!");
            }
        }
        public int PrintPassMethod()
        {
            return 1056 + 3790;
        }
    }
}
