using employeeService.Core.Entities;
using employeeService.Core.RepositoryContracts;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace employeeServices.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly employeeServices.Infrastructure.EmployeeDbContext.EmployeeDbContext _dbContext;

        public EmployeeRepository(employeeServices.Infrastructure.EmployeeDbContext.EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.ToList();
        }
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            // return await _dbContext.Employees.ToListAsync();

            var info = await _dbContext.Employees.FromSqlRaw("exec SP_GetEmployees").ToListAsync();

            return info;
        }

        public Employee GetEmployeeById(int id)
        {
            return _dbContext.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();


        }
        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {

            var info = await _dbContext.Employees.FromSqlRaw("exec SP_GetEmployeeById @ID", new SqlParameter("@ID", id)).ToListAsync();

            return info.FirstOrDefault();

        }
    }
}
