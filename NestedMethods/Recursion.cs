using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedMethods
{
    class Recursion
    {
        public void RecursionMethod()
        {
            Console.WriteLine("Enter n value for n!");
            int number = Convert.ToInt32(Console.ReadLine());
            long fact = GetFactorial(number);
            Console.WriteLine("{0} factorial is {1}", number, fact);
        }

        private long GetFactorial(int number)
        {
            if (number == 0) //Base case / Termination case
                return 1;
            return number * GetFactorial(number - 1); //General case
        }

    }
}
