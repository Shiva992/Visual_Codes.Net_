using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    public class EmployeeModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public static List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> employeeModels = new List<EmployeeModel>();
            EmployeeModel em = new EmployeeModel() { id = 1, Name = "Shiva", City = "Delhi", Country = "India" };
            EmployeeModel em1 = new EmployeeModel() { id = 2, Name = "Tilak", City = "Chandausi", Country = "India" };
            EmployeeModel em2 = new EmployeeModel() { id = 3, Name = "Anita", City = "Moradabad", Country = "India" };
            EmployeeModel em3 = new EmployeeModel() { id = 4, Name = "Anand", City = "Moradabad", Country = "India" };
            EmployeeModel em4 = new EmployeeModel() { id = 5, Name = "RadhaKrishna", City = "Chandausi", Country = "India" };
            EmployeeModel em5 = new EmployeeModel() { id = 6, Name = "RadheKrishhnaa", City = "Mathura", Country = "India" };
            employeeModels.Add(em);
            employeeModels.Add(em1);
            employeeModels.Add(em2);
            employeeModels.Add(em3);
            employeeModels.Add(em4);
            employeeModels.Add(em5);
            return employeeModels;
        }

    }
}
