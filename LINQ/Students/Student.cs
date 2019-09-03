using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public ICollection<string> Courses { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> result = new List<Student>
            {
                new Student{FirstName="Shod", LastName="Sadiev", Gender="Male", Courses= new Collection<string>{"Biology","Chemical","Phisic" } },
                new Student{FirstName="Bob", LastName="Harrison", Gender="Male", Courses=new Collection<string>{"Chemical","Phisic" } },
                new Student{FirstName="Olga", LastName="Zakharova", Gender="Female", Courses=new Collection<string>{"Programming","Math","English" } }
            };
            return result;
        }
    }
}
