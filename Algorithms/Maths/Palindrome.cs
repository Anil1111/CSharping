using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Maths
{
    class Palindrome
    {
        public void IsPalindrome()
        {
            int k=123;

            int a = k % 10;
            int b = k % 100;
            int c = b / 10;
            int d = k / 100;

            int sum = (a * 100) + (c * 10) + d;
            Console.WriteLine("The Inverted number is =" + sum);

            if (k == sum)
                Console.WriteLine("The given number is a palindrome");
            else
                Console.WriteLine("The given number is not a palindrome");

        }
    }
}
