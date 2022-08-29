using System.ComponentModel.DataAnnotations;

namespace ShivaStudents.Models
{

    public class Employee
    {
        [Required(ErrorMessage = "Please Enter Employee ID...!")]
        public int EmployeeId { get; set; }


        [Required(ErrorMessage = "Please Enter Employee Name...!")]       
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Salary...!")]
        
        public int Salary { get; set; }

        [Required(ErrorMessage = "Please Enter City...!")]
        public string City { get; set; }

    
        [Required(ErrorMessage = "Please Enter Gender...!")]

        public string Gender { get; set; }

        
        [Required(ErrorMessage = "Please Select Department...!")]
        public int DepartmentID { get; set; }

        public Department Department { get; set; }


    }
}
