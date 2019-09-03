using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    class DeferredExecution
    {
        public static void Deferred()
        {
            var allStudents = Student.GetAllStudents().ToList();
            var femaleStudent = from student in allStudents
                                where student.Gender == "Female"
                                select student;
            //var femaleStudent = (from student in allStudents
            //                    where student.Gender == "Female"
            //                    select student).ToList();
            allStudents.Add(new Student {FirstName="Anisa",LastName="Sadieva",Gender="Female" });
            foreach (var item in femaleStudent)
            {
                Console.WriteLine(item.FirstName+" "+item.LastName);
            }
        }
    }
}
