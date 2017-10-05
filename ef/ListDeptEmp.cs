using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo.ef
{
    class ListDeptEmp
    {
        static void Main(string[] args)
        {
            HRContext ctx = new HRContext();
            ctx.Database.Log = Console.WriteLine;

            ctx.Configuration.LazyLoadingEnabled = false; 

            foreach(var d  in ctx.Departments)
            {
                Console.WriteLine(d.DepartmentName);
                // Explit loading 
                ctx.Entry(d).Collection(dept => dept.Employees).Load();

                foreach(var e in d.Employees)
                {
                    Console.WriteLine("   " + e.Name);
                }
            }
        }
    }
}
