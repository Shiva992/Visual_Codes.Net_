namespace ShivaStudents.Models
{
    
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll { get; }
        int CreateEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int RemoveEmployee(Employee employee);
    }
}
