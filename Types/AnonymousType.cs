using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class AnonymousType
    {
        //https://www.tutorialsteacher.com/csharp/csharp-anonymous-type
        public void AMethod()
        {
            var myAnonymousType = new
            {
                firstProperty = "First",
                secondProperty = 2,
                thirdProperty = true
            };
            Console.WriteLine(myAnonymousType.GetType().ToString());
        }


        public void BMethod()
        {
            var myAnonymousType = new
            {
                firstProperty = "Second",
                secondProperty = 100,
                thirdProperty = false,
                anotherAnonymousType = new { nestedProperty = "Nested" }
            };

            CMethod(myAnonymousType);
        }


        public void CMethod(dynamic param)
        {
            Console.WriteLine(param.firstProperty);
        }

    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
    }

    public class StudentAnonymous
    {

        public void EMethod()
        {
            IList<Student> studentList = new List<Student>() {
                        new Student() { StudentID = 1, StudentName = "John", age = 18 } ,
                        new Student() { StudentID = 2, StudentName = "Steve",  age = 21 } ,
                        new Student() { StudentID = 3, StudentName = "Bill",  age = 18 } ,
                        new Student() { StudentID = 4, StudentName = "Ram" , age = 20  } ,
                        new Student() { StudentID = 5, StudentName = "Ron" , age = 21 }
                    };

            var studentNames = from s in studentList
                               select new
                               {
                                   StudentID = s.StudentID,
                                   StudentName = s.StudentName
                               };
        }

    }
}
