using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Parsing
    {
        public void ParsingMethod()
        {
            //Convert string(Grammar) to math and math to string(Grammar)

            string s = "23";
            int si = Convert.ToInt32(s);
            Console.WriteLine("Converted string to int " + si);

            char c = '4';
            int ci = Convert.ToInt32(c);
            Console.WriteLine("Converted Char to int " + ci);

            Console.WriteLine("Please enter your string to parse/convert into a real number:");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your string to print the input:");
            string ip = Console.ReadLine();

            Console.WriteLine("The input is parsed as {0}", ip);

        }
    }
}
