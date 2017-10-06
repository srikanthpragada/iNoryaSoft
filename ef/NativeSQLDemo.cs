using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo.ef
{
    class DeptInfo
    {
        public int DepartmentId { get; set; }
        public int Count { get; set; }
    }

    class NativeSQLDemo
    {
        static void Main(string[] args)
        {
            using (HRContext ctx = new HRContext())
            {
                ctx.Database.Log = Console.WriteLine;

                var depts = ctx.Departments.SqlQuery
                                ("select * from departments").ToList<Department>();

                foreach(var d in depts)
                {
                    Console.WriteLine(d.DepartmentName);
                }

                var count = ctx.Database.SqlQuery<Int32>
                                ("select count(*) from departments").First<Int32>();

                Console.WriteLine(count);

                var deptinfo  = ctx.Database.SqlQuery<DeptInfo>
                                ("select DepartmentId, Count = count(*) from employees group by departmentid").ToList<DeptInfo>();

                
                foreach(var dinfo in deptinfo)
                {
                    Console.WriteLine("{0} {1}", dinfo.DepartmentId, dinfo.Count);
                }

                // Nonquery sql

                int result = ctx.Database.ExecuteSqlCommand
                      ("update employees set salary = salry * 1.1");
                Console.WriteLine(result);






            }

        }
    }
}
