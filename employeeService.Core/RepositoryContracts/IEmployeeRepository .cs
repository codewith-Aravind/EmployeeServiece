using employeeService.Core.Entities;

namespace employeeService.Core.RepositoryContracts
{
    public interface IEmployeeRepository
    {
        public List<employeeService.Core.Entities.Employee> GetAllEmployees();
        public Task<List<Employee>> GetAllEmployeesAsync();
        public Employee GetEmployeeById(int id);
        public Task<Employee> GetEmployeeByIdAsync(int id);
    }
}
