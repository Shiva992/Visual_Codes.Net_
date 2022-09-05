using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShivaEmployee.Models;

namespace ShivaEmployee.Controllers
{
    public class EmployeeController: Controller
    {
        [Authorize]
        public async Task<ViewResult> List()
        {
            IEnumerable<Employee> employees = new List<Employee>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7218/api/Employee/List"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employees = JsonConvert.DeserializeObject<IEnumerable<Employee>>(apiResponse);
                }
            }
            return View(employees);

        }
        public async Task<IActionResult> Create(Employee employee)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsJsonAsync("https://localhost:7218/api/Employee/AddEmployee", employee))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return View();
        }
        public async Task<IActionResult> Delete(int Id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:7218/api/Employee/DeleteEmployee?Id=" + Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("List");
        }
        public async Task<IActionResult> Edit(int id)

        {
            var employee = new Employee();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7218/api/Employee/GetEmployeeByID?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                }
            }
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:7218/api/Employee/DeleteEmployee?Id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return View(employee);
        }


        public async Task<IActionResult> Update(Employee employee)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PutAsJsonAsync("https://localhost:7218/api/Employee/UpdateEmployee", employee))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                }
            }
            return RedirectToAction("List");

        }

    }
}
