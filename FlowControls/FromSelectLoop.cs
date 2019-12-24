using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControls
{
    class FromSelectLoop
    {
        public void FromSelectMethod()
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
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int age { get; set; }
        }
    }
}
