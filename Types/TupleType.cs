using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{   //https://docs.microsoft.com/en-us/dotnet/csharp/tuples
    //Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
    //A tuple can only include maximum eight elements only
    //Tuple is a reference type and not a value type
    class TupleType
    {
        
        public void TupleTypeMethod()
        {
            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Kanna", "Reddy");
            Console.WriteLine(person.Item1); 
            Console.WriteLine(person.Item2); // returns (8)
            Console.WriteLine(person.Item3); // returns 8
        }
        

        public void MaximumElementsTuple()
        {
            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);  //max eight elements can be accomdate 
            Console.WriteLine(numbers.Item1); // returns "One"
            Console.WriteLine(numbers.Item2); // returns 2
            Console.WriteLine(numbers.Item3); // returns 3
            Console.WriteLine(numbers.Item4); // returns "Four"
            Console.WriteLine(numbers.Item5); // returns 5
            Console.WriteLine(numbers.Item6); // returns "Six"
            Console.WriteLine(numbers.Item7); // returns 7
            Console.WriteLine(numbers.Rest); // returns (8) 
            Console.WriteLine(numbers.Rest.Item1); // returns 8
        }

        public void NestedTuple()
        {
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(numbers.Item1);  // returns 1
            Console.WriteLine(numbers.Item7);  // returns 7
            Console.WriteLine(numbers.Rest.Item1);//returns (8, 9, 10, 11, 12, 13)
            Console.WriteLine(numbers.Rest.Item1.Item1); //returns 8
            Console.WriteLine(numbers.Rest.Item1.Item2); //returns 9
        }

        public void ParameterTuple(Tuple<int, string, string> person) //When you want to pass multiple values to a method through a single parameter.
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }
        public Tuple<int, string, string> ReturnTypeTuple() //When you want to return multiple values from a method without using ref or out parameters.
        {
            return Tuple.Create(1, "Bill", "Gates");
        }



    }
}
