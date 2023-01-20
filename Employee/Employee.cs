using System.ComponentModel.DataAnnotations;

namespace Employee
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
    }
}
