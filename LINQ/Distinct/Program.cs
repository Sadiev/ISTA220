using System;
using System.Collections.Generic;
using System.Linq;

namespace Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new List<string> { "USA", "usa", "Tajikistan", "UK", "UK" };
            var result = countries.Distinct(StringComparer.OrdinalIgnoreCase);
            countries.ForEach(Console.WriteLine);
            Console.WriteLine("==============================================================");
            Console.WriteLine(string.Join(", ", result));


            Console.WriteLine("==============================================================");
            List<Student> students = new List<Student> {
                new Student {ID=1,Name="Shod" },
                new Student {ID=2,Name="Shod" },
                new Student {ID=3,Name="Max" },
            };

            var distinctStudents = students.Select(x=>new {x.Name }).Distinct();

            foreach (var item in distinctStudents)
            {
                Console.WriteLine(item.Name);
            }
           
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
