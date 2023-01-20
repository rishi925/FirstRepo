using System.ComponentModel.DataAnnotations;

namespace Student
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public DateTime StudentBirthDate { get; set; }
    }
}
