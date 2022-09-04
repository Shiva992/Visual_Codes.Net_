using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShivaStudents.Models;
using System.IO.Pipelines;

namespace ShivaStudents.Controllers

{
    [ApiController]
    [Route("api/Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("GetEmployeeByID")]
        public IActionResult GetEmployeeByID(int id)
        {
            var employee = employeeRepository.GetAll.FirstOrDefault(s => s.EmployeeId == id);
            return Ok(employee);
        }

        [HttpGet]
        [Route("List")]
        public IActionResult List()
        {
            try
            {
                var employees = this.employeeRepository.GetAll;

                return Ok(employees);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server error");
            }
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            try
            {
                var insertedEmployee = this.employeeRepository.CreateEmployee(employee);
                return Ok(insertedEmployee);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            try
            {
                var updatedEmployee = this.employeeRepository.UpdateEmployee(employee);
                return Ok(updatedEmployee);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpDelete]
        [Route("DeleteEmployee")]
        public IActionResult DeleteEmployee(int Id)
        {
            try
            {
                var deletedEmployee = this.employeeRepository.RemoveEmployee(Id);
                return Ok(deletedEmployee);
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        }
    }
}

       