using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            LambdaExpression lambdaExpression = new LambdaExpression();
            Console.WriteLine(lambdaExpression.testForEquality(4, 5));
            Console.WriteLine(lambdaExpression.testForEquality1(4, 5));
            Console.WriteLine(lambdaExpression.e);
            lambdaExpression.greet("Kanna");
            lambdaExpression.line1();
            lambdaExpression.line();
            lambdaExpression.BMethod();
            lambdaExpression.AMethod();

            //Recursion recursion = new Recursion();
            //recursion.RecursionMethod();

            //A a = new A();
            //a.AMethod();
            //a.AMethod().AMethod1();
            //a.AMethod().AMethod1().AMethod2();

            Console.ReadLine();
        }
    }
}
