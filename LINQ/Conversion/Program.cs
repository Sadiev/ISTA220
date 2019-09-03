using System;
using System.Collections.Generic;
using System.Linq;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> {
                new Employee { ID = 100, Name = "Alex", Job = "Developer", City = "Durham" },
                new Employee { ID = 101, Name = "Ann", Job = "Developer", City = "Dushanbe" },
                new Employee { ID = 102, Name = "Shod", Job = "Developer", City = "Fayetteville" },
                new Employee { ID = 103, Name = "Masi", Job = "Designer", City = "Durham" },
                new Employee { ID = 104, Name = "Amira", Job = "Developer", City = "Messa" },
                new Employee { ID = 105, Name = "Anisa", Job = "Developer", City = "Tempe" },
                //new Employee { ID = 105, Name = "Anisa", Job = "Developer", City = "Tempe" }//Error: need a unic ID
            };
            Employee[] arrEmployee = employees.ToArray();
            List<Employee> listEmployee = arrEmployee.ToList();

            //Dictionary<int, string> dicEmployee = employees.ToDictionary(x=>x.ID,x=>x.Name);
            Dictionary<int, Employee> dicEmployee = employees.ToDictionary(x => x.ID);
            foreach (var item in dicEmployee)
            {
                Console.WriteLine(item.Value);
            }

            var lookUpEmployee = employees.ToLookup(x => x.Job);
            foreach (var item in lookUpEmployee)
            {
                Console.WriteLine(item.Key);
                foreach (var emp in lookUpEmployee[item.Key])
                {
                    Console.WriteLine("\t"+emp);
                }
            }
        }
    }
}
