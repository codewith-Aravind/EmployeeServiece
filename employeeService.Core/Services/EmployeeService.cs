using employeeService.Core.DTO;
using employeeService.Core.ServiceContracts;

namespace employeeService.Core.Services
{
    /// <summary>
    /// Created By: Aravind Vagari
    /// Created On: 01/12/2025
    /// Represents the Employee Service.
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        List<EmployeeResponse> tblemployees = new List<EmployeeResponse>(); // let's assume this is our in-memory data store (Database)
        public EmployeeService()
        {
            LoadEmployeesData();
        }

        private void LoadEmployeesData()
        {
            tblemployees.Add(new EmployeeResponse { EmployeeId = 1, EmployeeName = "John Doe", Salary = 50000, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            tblemployees.Add(new EmployeeResponse { EmployeeId = 2, EmployeeName = "Jane Smith", Salary = 60000, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            tblemployees.Add(new EmployeeResponse { EmployeeId = 3, EmployeeName = "Mike Johnson", Salary = 55000, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
        }

        public EmployeeResponse CreateEmployee(EmployeeRequest employeeRequest)
        {

            return null;
        }

        public bool DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeResponse> GetAllEmployees()
        {
            if (!tblemployees.Any())
            {
                throw new Exception("No employees found.");
            }
            return tblemployees;
        }

        public EmployeeResponse GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public EmployeeResponse UpdateEmployee(EmployeeRequest employeeRequest)
        {
            return new EmployeeResponse();
        }

        public async Task<List<EmployeeResponse>> GetAllEmployeesAsync()
        {
            return new List<EmployeeResponse>();
        }

        public async Task<EmployeeResponse> GetEmployeeByIdAsync(int employeeId)
        {
            return new EmployeeResponse();
        }
    }
}
