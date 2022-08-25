using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_linqtosql_SP_CRUD.Models
{
    public class EmpClass
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
    }
}