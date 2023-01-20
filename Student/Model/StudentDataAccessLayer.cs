namespace Student.Model
{
    public class StudentDataAccessLayer:IStudent
    {
        private readonly StudentDbContext _context;
        public StudentDataAccessLayer(StudentDbContext context)
        {
            _context = context;
        }

        public void AddStudent(Student student)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
        }
    }
}
