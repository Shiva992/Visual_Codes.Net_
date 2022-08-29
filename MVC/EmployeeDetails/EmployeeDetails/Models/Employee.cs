namespace EmployeeDetails.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
