namespace ShivaStudents.Models
{
    [CustomExceptionHandlerFilter]
    public class EmployeeRepository : IEmployeeRepository
    {
       
        private readonly AppDbContext appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Employee> GetAll => appDbContext.Employees;
        public int CreateEmployee(Employee employee)
        {
            appDbContext.Employees.Add(employee);
            return appDbContext.SaveChanges();
        }
        public int RemoveEmployee(Employee employee)
        {
            appDbContext.Employees.Remove(employee);
            return appDbContext.SaveChanges();
        }

        public int UpdateEmployee(Employee employee)
        {
            appDbContext.Employees.Update(employee);
            return appDbContext.SaveChanges();
        }
        
    }
}
