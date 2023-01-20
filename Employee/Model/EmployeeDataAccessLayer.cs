namespace Employee.Model
{
    public class EmployeeDataAccessLayer:IEmployee
    {
        private readonly EmployeeDbContext _context;
        public EmployeeDataAccessLayer(EmployeeDbContext context)
        {
            _context = context;
        }

        public void AddEmplyee(Employee employee)
        {
            _context.Employee.Add(employee);    
            _context.SaveChanges();
        }
    }
}
