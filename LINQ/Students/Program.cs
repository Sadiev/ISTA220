using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = Student.GetAllStudents().Select(s=>s.FirstName +" "+s.LastName);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("########################################");
            

            IEnumerable<string> myCourses = Student.GetAllStudents().SelectMany(s => s.Courses).Distinct();
            foreach (var item in myCourses)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("########################################");
            

            IEnumerable<string> myCoursesSQL = (from student in Student.GetAllStudents()
                                               from course in student.Courses
                                               select course).Distinct();
            foreach (var item in myCourses)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("########################################");

            var students = Student.GetAllStudents().SelectMany(s=>s.Courses,(s,course)=> new {Name=s.FirstName+" "+s.LastName, Course=course  });
            foreach (var item in students)
            {
                Console.WriteLine(item.Name+'\t'+item.Course);
            }
            Console.WriteLine("########################################");

            var studentsSQL = from student in Student.GetAllStudents()
                              from course in student.Courses
                              select new {Name= student.FirstName + " " + student.LastName, Course = course };
            foreach (var item in studentsSQL)
            {
                Console.WriteLine(item.Name + '\t' + item.Course);
            }
            Console.WriteLine("########################################");

            var studentsOrderBy = Student.GetAllStudents().OrderBy(s=>s.LastName).ThenBy(s=>s.FirstName);// or OrderByDescending() / ThenByDescending()
            //var SQLversion = from student in Student.GetAllStudents()
            //          orderby student.LastName, student.FirsName descending // or ascending
            //          select student;
            foreach (var item in studentsOrderBy)
            {
                Console.WriteLine(item.LastName + '\t' + item.FirstName);
            }
            Console.WriteLine("########################################");

            var studentsReverse = (from student in Student.GetAllStudents()
                                  select student).Reverse();
            foreach (var item in studentsReverse)
            {
                Console.WriteLine(item.LastName + '\t' + item.FirstName);
            }
            Console.WriteLine("########################################");

            DeferredExecution.Deferred();
            Console.ReadKey();


        }
    }
}
