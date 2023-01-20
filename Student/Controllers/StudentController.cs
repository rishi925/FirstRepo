using Microsoft.AspNetCore.Mvc;
using Student.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudent _student;
        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpPost]
        [Route("AddStudent")]
        public void AddStudent(Student student)
        {
            _student.AddStudent(student);
            
        }
    }
}
