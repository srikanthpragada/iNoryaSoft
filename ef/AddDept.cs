using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo.ef
{
    class AddDept
    {
        static void Main(string[] args)
        {
          
            HRContext ctx = new HRContext();
            ctx.Database.Log = Console.WriteLine;

            var dept = new Department {DepartmentName = "Accounts" };

            dept.Employees.Add(new Employee { Name = "Robert", Salary = 55000 });
            dept.Employees.Add(new Employee { Name = "Mike", Salary = 75000 });


            ctx.Departments.Add(dept);
            ctx.SaveChanges();

        }

    }
}
