using AutoMapper;
using employeeService.Core.DTO;
using employeeService.Core.RepositoryContracts;
using employeeService.Core.ServiceContracts;

namespace employeeService.Core.Services
{
    public class ContractEmployeeService : IEmployeeService
    {
        List<EmployeeResponse> tblemployees = new List<EmployeeResponse>(); // let's assume this is our in-memory data store (Database)

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public ContractEmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public EmployeeResponse CreateEmployee(EmployeeRequest employeeRequest)
        {
            if (tblemployees != null)
            {
                EmployeeResponse createEmployeeRequest = new EmployeeResponse()
                {
                    EmployeeId = employeeRequest.EmployeeId,
                    EmployeeName = employeeRequest.EmployeeName,
                    EmployeeAge = employeeRequest.EmployeeAge,
                    Salary = employeeRequest.Salary,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                };

                tblemployees.Add(createEmployeeRequest);

                return createEmployeeRequest;
            }
            else
            {
                return new EmployeeResponse();
            }

        }

        public bool DeleteEmployee(int employeeId)
        {
            if (employeeId != 0)
            {
                var res = tblemployees.FirstOrDefault(x => x.EmployeeId == employeeId);
                var result = tblemployees.RemoveAll(x => x.EmployeeId == employeeId);
                if (res != null && result > 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }


        public List<EmployeeResponse> GetAllEmployees()
        {

            var result = _employeeRepository.GetAllEmployees();

            List<EmployeeResponse> info = _mapper.Map<List<EmployeeResponse>>(result);

            return info;

        }

        public async Task< EmployeeResponse> GetEmployeeByIdAsync(int employeeId)
        {
            var info = await _employeeRepository.GetEmployeeByIdAsync(employeeId);

            if (info != null)
                return new EmployeeResponse
                {
                    EmployeeId = info.EmployeeId,
                    CreatedDate = info.CreatedDate,
                    EmployeeAge = info.EmployeeAge,
                    EmployeeName = info.EmployeeName,
                    Salary = info.Salary,
                    UpdatedDate = info.UpdatedDate
                };
            else
                return new EmployeeResponse();
        }

        public EmployeeResponse GetEmployeeById(int employeeId)
        {
            var info = _employeeRepository.GetEmployeeById(employeeId);

            if (info != null)
                return new EmployeeResponse
                {
                    EmployeeId = info.EmployeeId,
                    CreatedDate = info.CreatedDate,
                    EmployeeAge = info.EmployeeAge,
                    EmployeeName = info.EmployeeName,
                    Salary = info.Salary,
                    UpdatedDate = info.UpdatedDate
                };
            else
                return new EmployeeResponse();
        }

        public EmployeeResponse UpdateEmployee(EmployeeRequest employeeRequest)
        {

            if (employeeRequest.EmployeeId != 0)
            {
                var res = tblemployees.FirstOrDefault(x => x.EmployeeId == employeeRequest.EmployeeId);
                if (res != null)
                {
                    res.EmployeeName = employeeRequest.EmployeeName;
                    res.EmployeeAge = employeeRequest.EmployeeAge;
                    res.Salary = employeeRequest.Salary;
                    res.UpdatedDate = DateTime.Now;

                    return res;
                }
                else
                {
                    throw new Exception("Contract Employee not found to update.");
                }
            }
            return new EmployeeResponse();
        }

        public async Task<List<EmployeeResponse>> GetAllEmployeesAsync()
        {
            var result = await _employeeRepository.GetAllEmployeesAsync();

            List<EmployeeResponse> info = _mapper.Map<List<EmployeeResponse>>(result);

            return info;
        }
    }
}
