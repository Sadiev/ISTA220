using System;
using System.Collections.Generic;
using System.Text;

namespace GroupJoin
{
    class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static IEnumerable<Department> GetAllDepartments()
        {
            return new List<Department> {
                new Department { ID=1,Name="IT"},
                new Department { ID=2,Name="HR"},
                new Department { ID=3,Name="Accounting"},
            };
        }
    }
}
