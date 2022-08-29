using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShivaStudents.Models;

namespace ShivaStudents.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartmentRepository departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
        [Authorize]
        public ViewResult List()
        {
            var departments = this.departmentRepository.Departments;

            return View(departments);

        }
        public ViewResult Create()
        {
            return View();
        }

        public IActionResult CreateDepartment(Department department)
        {
            int result = departmentRepository.CreateDepartment(department);
            return RedirectToAction("List");
        }
        public ViewResult Edit(int id)
        {
            var department = departmentRepository.Departments.FirstOrDefault(s => s.DepartmentID == id);
            return View(department);
        }


        public IActionResult UpdateDepartment(Department department)
        {
            departmentRepository.UpdateDepartment(department);
            return RedirectToAction("List");
        }
        public IActionResult Remove(int id)
        {
            var department = departmentRepository.Departments.FirstOrDefault(s => s.DepartmentID == id);
            departmentRepository.RemoveDepartment(department);
            return RedirectToAction("List");

        }
    }
}
