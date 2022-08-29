using System.ComponentModel.DataAnnotations;

namespace ShivaStudents.Models
{
    public class Department
    {
        [Required(ErrorMessage = "Please Select Department...!")]
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Please Select DepartmentName...!")]
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "Please Select Department...!")]
        public List<Employee> Employees { get; set; }
    }
}