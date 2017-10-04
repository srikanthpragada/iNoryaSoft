using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo.ef
{
    class ListDept
    {
        static void Main(string[] args)
        {
             //AddDept();
            // Console.WriteLine();
            
             DeleteDept();
            // UpdateDept();

            // List();
        }

        static void AddDept()
        {
            HRContext ctx = new HRContext();
            ctx.Database.Log = Console.WriteLine;

            var dept = new Department {DepartmentName = "Production" };

            Console.WriteLine(ctx.Entry(dept).State);

            ctx.Departments.Add(dept);

            Console.WriteLine(ctx.Entry(dept).State);


            ctx.SaveChanges();
        }


        static void DeleteDept()
        {
            HRContext ctx = new HRContext();
            ctx.Database.Log = Console.WriteLine;

            var dept = ctx.Departments.Find(1);
            if (dept == null)
            {
                Console.WriteLine("Sorry! Dept not found");
                return;
            }

            ctx.Departments.Remove(dept);
            ctx.SaveChanges();
        }

        static void UpdateDept()
        {
            HRContext ctx = new HRContext();
            ctx.Database.Log = Console.WriteLine;

            var dept = ctx.Departments.Find(1);

            if ( dept == null)
            {
                Console.WriteLine("Sorry! Dept not found");
                return;
            }

            Console.WriteLine(ctx.Entry(dept).State);  // Unchanged
            dept.DepartmentName = "Accounts";
            Console.WriteLine(ctx.Entry(dept).State);  // Modified 
            ctx.SaveChanges();
        }



        static void List()
        {
            HRContext ctx = new HRContext();
            ctx.Database.Log = Console.WriteLine;

            var depts = from d in ctx.Departments
                        select d;

            foreach (var d in depts)
            {
                Console.WriteLine("{0} {1}",d.DepartmentId, d.DepartmentName);
            }
        }
    }
}
