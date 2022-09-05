using System.ComponentModel.DataAnnotations;

namespace ShivaEmployee.Models
{
    public class Employee
    {
     
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "UserName Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email Address Required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
        public int Salary { get; set; }
        [Required(ErrorMessage = "City Required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only Alphabets are allowed")]
        public string City { get; set; }
    }
}
