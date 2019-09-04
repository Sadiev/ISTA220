using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    class GroupBy
    {
        public static void StudentByGollege()
        {
            //var studentGroups = Student.GetAllStudents().GroupBy(x=>x.College);
            var studentGroups = from students in Student.GetAllStudents()
                                group students by students.College;
            foreach (var item in studentGroups)
            {
                Console.WriteLine(item.Key+" - "+item.Count(x=>x.Gender=="Male") +" "+item.Max(x=>x.Age));
                foreach (var student in item)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} {student.Gender}");
                }
            }
        }
    }
}
