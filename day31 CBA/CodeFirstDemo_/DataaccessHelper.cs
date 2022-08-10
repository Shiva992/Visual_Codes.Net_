using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo_
{
    class DataaccessHelper
    {
        CodeFirstDemo_ _dbContext = new CodeFirstDemo_();
        public List<Employee>FetchEmployees()
        {
            return _dbContext.Employees.ToList();

        }
        public List<Department> FetchDepartments()
        {
            ;

            return _dbContext.Departments.ToList();

        }
        public int Add(Employee employee)
        {

            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee.EmployeeId;
        }
        public int AddDept(Department department)
        {
            _dbContext.Departments.Add(department);
            _dbContext.SaveChanges();
            return department.DepartmentId;
        }
    }
}
