using System;
using System.Linq;

namespace GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            //var empByDep = Department.GetAllDepartments().GroupJoin(Employee.GetAllEmployees(), d => d.ID, e => e.DepartmentID,
            //    (dep,empl)=>new {Department=dep,Employee=empl });
            var empByDep = from dep in Department.GetAllDepartments()
                           join emp in Employee.GetAllEmployees()
                           on dep.ID equals emp.DepartmentID into eGroup
                           select new {
                               Department =dep,
                               Employee=eGroup
                           };
            foreach (var dept in empByDep)
            {
                Console.WriteLine(dept.Department.Name);
                foreach (var emp in dept.Employee)
                {
                    Console.WriteLine($"\t{emp.Name}");
                }
            }
        }
    }
}
