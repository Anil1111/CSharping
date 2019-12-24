using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class ExceptionHandle
    {
        public void ExceptionMethod()
        {
            int a = 1, b = 0, c;

            try
            {
                c = a % b;  // try 0/0 and 0%0
                Console.WriteLine("The value is : " + c);
            }
            catch(Exception e)
            {
                Console.WriteLine("Some exception has been caught with message: " + e);
            }
            finally
            {
                Console.WriteLine("Finally Restart the program with different value");
            }
        }

        public void CustomException()
        {
            int a = 1, b = 0, c;
            try
            {
                if (a > b)
                {
                    throw new myCustomException("The Exception is created by me ");
                }
            }
            catch (myCustomException e)
            {
                Console.WriteLine("The catch block is printed with exception found in runtime : "+ e);
            }
            finally
            {
                Console.WriteLine("The Finally block is executed Finally");
            }
        }

        public void CheckedUncheckedMethod()
        {
            unchecked  //The Unchecked keyword ignores the integral type arithmetic exceptions.
            {
                int b = int.MaxValue;
                Console.WriteLine(b + 1);
            }
            checked//This program throws an exception and stops program execution.
            {
                int a = int.MaxValue;  //Property value from int class
                //Console.WriteLine(a + 1);
            }
        }
        public void SystemException() 
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 25;
            }
            catch (SystemException e)  // SystemException  This class can be used to handle exception of subclasses.
            {
                Console.WriteLine(e);
            }
        }
    }

    class myCustomException : Exception
    {
        public myCustomException(String message) : base(message)//invokes base class constructor
        {

        }
    }
}
