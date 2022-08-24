using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActionResultTypes.Controllers
{
    public class ResultTypesController
    {
        public ViewResult ShowEmployee()
        {
            Employee employee = new Employee()
            {
                EmployeeID = 1,
                FirstName = "Antony",
                LastName = "Paul",
                Location = "Bangalore",
                Email = "Paul@gmail.com"
            };
            return View(employee);
        }
        public ContentResult ContentResultTest()
        {
            return Content("<b>Hello from GL<b>", "text/html", System.Text.Encoding.UTF8);
        }
        public RedirectResult RedirectResultTest()
        {
            return Redirect("https://google.com");
        }
        public FileResult FileResultTest()
        {
            return File("/downloads/sample.pdf", "application.pdf");

        }
        public StatusCodeResult StatusCodeResultTest()
        {
            return StatusCode(200);
        }
    }
}