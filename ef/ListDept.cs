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
            // AddDept();
            // Console.WriteLine();
            List();
        }

        static void AddDept()
        {
            HRContext ctx = new HRContext();
            ctx.Database.Log = Console.WriteLine;

            var dept = new Department { DepartmentName = "Stores" };

            ctx.Departments.Add(dept);
            ctx.SaveChanges();
        }



        static void List()
        {
            HRContext ctx = new HRContext();
            ctx.Database.Log = Console.WriteLine;

            var depts = from d in ctx.Departments
                            // where d.DepartmentId < 10 
                        orderby d.DepartmentName
                        select d;

            foreach (var d in depts)
            {
                Console.WriteLine("{0} {1}",d.DepartmentId, d.DepartmentName);
            }
        }
    }
}
