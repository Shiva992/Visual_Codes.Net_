using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShivaStudents.Models;

namespace ShivaStudents.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [Authorize]

        public ViewResult List()
        {
            var employees = this.employeeRepository.GetAll;

            return View(employees);

        }
        [Authorize]
        public ViewResult Department1()
        {
            IEnumerable<Employee> employees = new List<Employee>();
            employees = this.employeeRepository.GetAll.Where(d=>d.DepartmentID==1);

            return View(employees);

        }
        [Authorize]
        public ViewResult Department2()
        {
            IEnumerable<Employee> employees = new List<Employee>();
            employees = this.employeeRepository.GetAll.Where(d => d.DepartmentID == 2);

            return View(employees);

        }
        [Authorize]
        public ViewResult Department3()
        {
            IEnumerable<Employee> employees = new List<Employee>();
            employees = this.employeeRepository.GetAll.Where(d => d.DepartmentID == 3);

            return View(employees);

        }

        public ViewResult Create()
        {
            return View();
        }

        public IActionResult CreateEmployee(Employee employee)
        {
            int result = employeeRepository.CreateEmployee(employee);
            return RedirectToAction("List");
        }
        public ViewResult Edit(int id)
        {
            var employee = employeeRepository.GetAll.FirstOrDefault(s => s.EmployeeId==id);
            return View(employee);
        }


        public IActionResult UpdateEmployee(Employee employee)
        {
            employeeRepository.UpdateEmployee(employee);
            return RedirectToAction("List");
        }
        public IActionResult Remove(int id)
        {
            var employee = employeeRepository.GetAll.FirstOrDefault(s => s.EmployeeId == id);
            employeeRepository.RemoveEmployee(employee);
            return RedirectToAction("List");

        }
    }
}
