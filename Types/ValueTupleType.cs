using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{   //https://www.tutorialsteacher.com/csharp/valuetuple
    class ValueTupleType  //similar to TupleType
    {
        public void ValueTupleTypeMethod()
        {
            var person1 = (1, "Bill", "Gates");// var person = Tuple.Create(1, "Bill", "Gates");

            ValueTuple<int, string, string> person2 = (1, "Bill", "Gates");
            Console.WriteLine(person2.Item1); // returns 1
            Console.WriteLine(person2.Item2); // returns "Bill"
            Console.WriteLine(person2.Item3); // returns "Gates"


            (int, string, string) person3 = (1, "Bill", "Gates");
            Console.WriteLine(person3.Item1);

            var number = (1); // int type, NOT a tuple
            var numberPair = (1, 2); //valid tuple

            var numbers = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);  //Unlike Tuple, a ValueTuple can include more than eight values.

            (int Id, string FirstName, string LastName) person4 = (1, "Bill", "Gates"); 
            Console.WriteLine(person4.Id); // returns 1
            Console.WriteLine(person4.FirstName); // returns "Bill"
            Console.WriteLine(person4.LastName); // returns "Gates"

            var person5 = (Id: 1, FirstName: "Bill", LastName: "Gates");  //We can also assign member names at the right side with values

            (int Id, string FirstName, string LastName) person6 = (PersonId: 1, FName: "Bill", LName: "Gates"); // PersonId, FName, LName will be ignored.

            //we can provide member names either at the left side or at the right side but not at both side

            (int, string, string) person7 = (PersonId: 1, FName: "Bill", LName: "Gates"); //// PersonId, FirstName, LastName will be ignored. It will have the default names: Item1, Item2, Item3.

            string person8FirstName = "Bill", person8LastName = "Gates";
            var person8 = (FirstName: person8FirstName, LastName: person8LastName);


            ValueTupleParameterType((1, "kanna", "reddy"));  //belongs to ValueTupleParameterType() method
        }

        public void ValueTupleParameterType((int, string, string) person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }

        public (int, string, string) ValueTupleReturnType()
        {
            return (Id: 1, FirstName: "Bill", LastName: "Gates");
        }

        public void ValueTupleDeconstruction()  //We can also use var instead of explicit data type names.
        {
            (int id, string FName, _) = ValueTupleDeconstructionReturnPerson();  //// use discard _ for the unused member LName
            Console.WriteLine(id);
            Console.WriteLine(FName);
        }
        public (int, string, string) ValueTupleDeconstructionReturnPerson()  
        {
            return (Id: 1, FirstName: "Bill", LastName: "Gates");
        }

    }
}
