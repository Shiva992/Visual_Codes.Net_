namespace ShivaStudents.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll { get; }
        int CreateEmployee(Employee employee); //RT
         Employee UpdateEmployee(Employee Id);
         Employee RemoveEmployee(int Id);
    }
}
