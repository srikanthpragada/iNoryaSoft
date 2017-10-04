using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo.ef
{
    public class Employee
    {
        // Scalar property 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary{ get; set; }
        public Nullable<int> DepartmentId { get; set; }

        // Navigation property 
        public virtual Department Department { get; set; }

    }
}
