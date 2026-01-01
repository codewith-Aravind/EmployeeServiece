using employeeService.Core.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace employeeService.Core
{
    public static class DependancyInjection
    {
        // Add extension methods for dependency injection here in the future

        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<ServiceContracts.IEmployeeService, Services.ContractEmployeeService>();
            services.AddValidatorsFromAssemblyContaining(typeof(EmployeeRequestValidator));
            return services;
        }
    }
}
