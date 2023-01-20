using Employee.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employeedata;
        public EmployeeController(IEmployee employeedata)
        {
            _employeedata = employeedata;
        }
        [HttpPost]
        [Route("AddEmployee")]
        public void AddEmployee(Employee employee)
        {
            _employeedata.AddEmplyee(employee);
        }
    }
}
