namespace ShivaStudents.Models
{
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
        public Employee RemoveEmployee(int Id)
        {
            var employee = GetAll.FirstOrDefault(e => e.EmployeeId == Id);
            var exit = this.appDbContext.Employees.Remove(employee);
            this.appDbContext.SaveChanges();
            return exit.Entity;
        }

        public Employee UpdateEmployee(Employee employee)
        {

            var entry = this.appDbContext.Employees.Update(employee);
            this.appDbContext.SaveChanges();
            return entry.Entity;
        }

    }
}
