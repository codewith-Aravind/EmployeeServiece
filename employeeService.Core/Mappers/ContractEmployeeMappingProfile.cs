using AutoMapper;
using employeeService.Core.DTO;

namespace employeeService.Core.Mappers
{
    public class ContractEmployeeMappingProfile : Profile
    {
        public ContractEmployeeMappingProfile() { 
        
            CreateMap<Entities.Employee, EmployeeResponse>()
                .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.EmployeeName))
                .ForMember(dest => dest.EmployeeAge, opt => opt.MapFrom(src => src.EmployeeAge))
                .ForMember(dest => dest.Salary, opt => opt.MapFrom(src => src.Salary))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(src => src.UpdatedDate));
        }
    }
}
