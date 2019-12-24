using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedMethods
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions

    //Must Try lambda expression in ECMA JavaScript Script 6 and Type Script in SimpleJavaScript Project of JavaScript
    class LambdaExpression
    {
        public void line() => Console.WriteLine("No Arguments simple method Lambda expression");

        public Action line1 = () => Console.WriteLine("Action line1 with no arguments");
        public Action<string> greet = name => { string greeting = $"Good Morning {name}!"; Console.WriteLine(greeting); };

        public Func<int, int, bool> testForEquality = (x, y) => x == y;
        public Func<int, int, int> testForEquality1 = (x, y) => { int u = 199; return u + x + y; };

        public System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;

        public void AMethod()
        {
            void Line() => Console.WriteLine("This Printed from Line() Method of AMethod() of Lambda Expression Class");
            Line();
        }


        public void BMethod()
        {
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // The call to Count forces iteration of the source
            int highScoreCount = scores.Where(n => n > 80).Count();

            Console.WriteLine("{0} scores are greater than 80", highScoreCount);
        }
        

        public void CMethod()            //Example Multiply = x => x * x;
            //Console.WriteLine(Multiply(2)); // 4 
        {


        }


    }
}
