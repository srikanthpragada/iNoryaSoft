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
        public HRContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\classroom\inoryasoft\csdemo\ef\hr.mdf;Integrated Security=True;MultipleActiveResultSets=True")
        {
           Database.SetInitializer<HRContext>(null);

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // changes default schema to the given schema 
            // modelBuilder.HasDefaultSchema("dbo");
            // modelBuilder.Entity<Employee>().
        }


        public  DbSet<Department> Departments { get; set; }
        public  DbSet<Employee> Employees { get; set; }
    }
}
