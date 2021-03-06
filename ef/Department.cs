﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo.ef
{
    // [Table("departments")]
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}
