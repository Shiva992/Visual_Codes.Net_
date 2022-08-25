using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModelDemo.ViewModels;
using ViewModelDemo.Models;

namespace ViewModelDemo.Controllers
{
    public class EmployteeController : Controller
    {
        Employee employee = new Employee()
        {
            EmployeeId = 101,
            nameof = "Harry",
            Gender = "Male",
            Department = "IT",
            Salary = 10000,
            AddressId = 1001

        };
        Address address = new Address()
        {
            AddressId = 1001,
            City = "Vermont",
            HttpApplicationState = "Newyork",
            Country = "USA",
            Pin = "0098765432456789"
        };
        EmployeeDetailsViewModel employeedetailsviewmodel = new EmployeeDetailsViewModel()
        {
            Employee = employee,
            Address = address,
            PageTitle = "Employee Detials Page",
            PageHeader = "Employee Details",
        };
        return ViewModelDemo(employeeDetailsViewModel);

    }
}
}