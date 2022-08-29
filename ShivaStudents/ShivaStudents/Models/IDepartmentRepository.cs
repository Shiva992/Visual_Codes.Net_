namespace ShivaStudents.Models
{
    public interface IDepartmentRepository
    {
         IEnumerable<Department> Departments { get;}
        int CreateDepartment(Department department);
        int UpdateDepartment(Department department);
        int RemoveDepartment(Department department);
    }
}
