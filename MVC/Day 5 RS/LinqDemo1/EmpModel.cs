using System;
using System.Collections.Generic;
using System.Text;

namespace LinqDemo
{
    public class EmployeeModel2
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

       public static List<EmployeeModel2> GetAllEmployees()
        {
            List<EmployeeModel2> employeeModels = new List<EmployeeModel2>();
            EmployeeModel2 em = new EmployeeModel2() { id = 1, Name = "Shiva", City = "Delhi", Country = "India" };
            EmployeeModel2 em1 = new EmployeeModel2() { id = 2, Name = "Tilak", City = "Chandausi", Country = "India" };
            EmployeeModel2 em2 = new EmployeeModel2() { id = 3, Name = "Anita", City = "Moradabad", Country = "India" };
            EmployeeModel2 em3 = new EmployeeModel2() { id = 4, Name = "Anand", City = "Moradabad", Country = "India" };
            EmployeeModel2 em4 = new EmployeeModel2() { id = 5, Name = "RadhaKrishna", City = "Chandausi", Country = "India" };
            EmployeeModel2 em5 = new EmployeeModel2() { id = 6, Name = "RadheKrishhnaa", City = "Mathura", Country = "India" };
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