using System;
using System.Collections.Generic;
using System.Text;

namespace GroupJoin
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public static IEnumerable<Employee> GetAllEmployees()
        {
            return new List<Employee> {
                new Employee { ID=1,Name="Alex", DepartmentID=1},
                new Employee { ID=2,Name="Anna", DepartmentID=1},
                new Employee { ID=3,Name="Maggy", DepartmentID=2},
                new Employee { ID=4,Name="Shod", DepartmentID=2},
                new Employee { ID=5,Name="John", DepartmentID=3},
                new Employee { ID=6,Name="Taylor", DepartmentID=3},
                new Employee { ID=7,Name="Linda", DepartmentID=2},
                new Employee { ID=8,Name="Kara", DepartmentID=1},
            };
        }
    }
}
