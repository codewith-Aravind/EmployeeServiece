using employeeService.Core.DTO;
using employeeService.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace employeeService.API.Contollers
{
    /// <summary>
    /// Created By: Aravind Vagari
    /// Created On: 01/12/2025
    /// Represents the Employee Controller.
    /// </summary>
    [Route("api/employeeservice")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        /// <summary>
        /// Created By: Aravind Vagari
        /// Created On: 01/12/2025
        /// Represents the Get Employee API.
        /// </summary>
        /// <returns></returns>
        [HttpGet("employee")]
        public async Task<IActionResult> GetAllEmployee()
        {
            List<EmployeeResponse> result = await _employeeService.GetAllEmployeesAsync();

            return Ok(result);
        }


        /// <summary>
        /// Created By: Aravind Vagari
        /// Created On: 01/12/2025
        /// Represents the Create Employee API.
        /// </summary>
        /// <returns></returns>
        [HttpPost("employee")]
        public ActionResult CreateEmployee(EmployeeRequest employeeRequest)
        {
            var result = _employeeService.CreateEmployee(employeeRequest);

            return Ok(result);
        }

        /// <summary>
        /// Created By: Aravind Vagari
        /// Created On: 01/12/2025
        /// Represents the Update Employee API.
        /// </summary>
        /// <returns></returns>
        [HttpPut("employee")]
        public ActionResult UpdateEmployee(EmployeeRequest employeeRequest)
        {
            var result = _employeeService.UpdateEmployee(employeeRequest);
            return Ok(result);
        }

        /// <summary>
        /// Created By: Aravind Vagari
        /// Created On: 01/12/2025
        /// Represents the Delete Employee API.
        /// </summary>
        /// <returns></returns>
        [HttpDelete("employee/{employeeId}")]
        public ActionResult DeleteEmployee(int employeeId)
        {
            var result = _employeeService.DeleteEmployee(employeeId);
            if (result)
                return Ok("Delete Employee details from employee service");
            else
                return Ok("Delete Employee details from employee service failed");
        }

        [HttpGet("employee/{employeeId}")]
        public ActionResult GetEmployeeById(int employeeId)
        {
            var result = _employeeService.GetEmployeeByIdAsync(employeeId);

            return Ok(result);

        }

    }
}
