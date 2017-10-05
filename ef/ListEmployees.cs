using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo.ef
{
    class ListEmployees
    {
        static void Main(string[] args)
        {
            HRContext ctx = new HRContext();
            ctx.Database.Log = Console.WriteLine;

            foreach(var e  in ctx.Employees.Include("Department"))
            {
                // Console.WriteLine(e.GetType().FullName);
                Console.WriteLine("{0} {1}",e.Name, e.Department.DepartmentName);
               
            }
        }
    }
}
