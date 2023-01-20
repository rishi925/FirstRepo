using Microsoft.EntityFrameworkCore;

namespace Student.Model
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
    }
}
