using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo.ef
{
    class HRContext : DbContext 
    {
        public HRContext() : base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {

        }

        public  DbSet<Department> Departments { get; set; }
    }
}
