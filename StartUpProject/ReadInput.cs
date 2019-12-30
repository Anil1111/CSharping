using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class ReadInput
    {
        public void ReadNumber()
        {
            Console.WriteLine("Please write your number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        public void ReadString()
        {
            Console.WriteLine("Please write your String: ");
            string str = Console.ReadLine();
            
            Console.Write("You have Entered String = \n"+ str);
           
        }

        //public void ReadString()
        //{
        //    Console.WriteLine("Please write your char: ");
        //    char[] c = Console.ReadKey();

        //    Console.Write("You have Entered Char = \n" + c);
        //}
    }
}
