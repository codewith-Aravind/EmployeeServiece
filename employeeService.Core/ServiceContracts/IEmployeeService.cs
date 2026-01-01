using employeeService.Core.DTO;

namespace employeeService.Core.ServiceContracts
{
    /// <summary>
    /// Created By: Aravind Vagari
    /// Created On: 01/12/2025
    /// Represents the Employee Service Contract.
    /// </summary>
    public interface IEmployeeService
    {
        // Define service contract methods here
        public List<EmployeeResponse> GetAllEmployees();
        public Task<List<EmployeeResponse>> GetAllEmployeesAsync();
        public EmployeeResponse GetEmployeeById(int employeeId);
        public Task<EmployeeResponse> GetEmployeeByIdAsync(int employeeId);
        public EmployeeResponse CreateEmployee(EmployeeRequest employeeRequest);
        public EmployeeResponse UpdateEmployee(EmployeeRequest employeeRequest);
        public bool DeleteEmployee(int employeeId);
    }
}
