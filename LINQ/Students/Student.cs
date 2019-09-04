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
        public string College { get; set; }
        public int Age { get; set; }
        public ICollection<string> Courses { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> result = new List<Student>
            {
                new Student{FirstName="Shod", LastName="Sadiev", Gender="Male", College="FTCC", Age=18, Courses= new Collection<string>{"Biology","Chemical","Phisic" } },
                new Student{FirstName="Bob", LastName="Harrison", Gender="Male", College="FTCC",Age=19, Courses=new Collection<string>{"Chemical","Phisic" } },
                new Student{FirstName="Olga", LastName="Zakharova", Gender="Female", College="ERAU", Age=22,Courses=new Collection<string>{"Programming","Math","English" } },
                new Student{FirstName="Tamara", LastName="Nazarova", Gender="Female", College="ERAU", Age=30,Courses=new Collection<string>{"Math","English" } },
                new Student{FirstName="Andrei", LastName="Baranov", Gender="Male", College="ERAU", Age=25,Courses=new Collection<string>{"Programming","Math","English" } }
            };
            return result;
        }
    }
}
