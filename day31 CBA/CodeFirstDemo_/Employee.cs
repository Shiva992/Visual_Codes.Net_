using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo_
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string  EmployeeName { get; set; }

        public string DepartmentId { get; set; }

        public virtual Department Department{get; set; }

    }
}
