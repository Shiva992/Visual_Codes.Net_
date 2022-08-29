using System.IO.Pipelines;

namespace ShivaStudents.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {

        private readonly AppDbContext appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Department> Departments => appDbContext.Departments;
        public int CreateDepartment(Department department)
        {
            appDbContext.Departments.Add(department);
            return appDbContext.SaveChanges();
        }
        public int RemoveDepartment(Department department)
        {
            appDbContext.Departments.Remove(department);
            return appDbContext.SaveChanges();
        }

        public int UpdateDepartment(Department department)
        {
            appDbContext.Departments.Update(department);
            return appDbContext.SaveChanges();
        }
        
    }
}
