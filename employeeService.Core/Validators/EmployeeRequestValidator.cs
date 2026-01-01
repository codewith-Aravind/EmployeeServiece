using employeeService.Core.DTO;
using FluentValidation;

namespace employeeService.Core.Validators
{
    public class EmployeeRequestValidator : AbstractValidator<EmployeeRequest>
    {
        public EmployeeRequestValidator()
        {
            // EmployeeName must not be empty and must have a length between 4 and 100 characters
            RuleFor(emp => emp.EmployeeName)
                .NotEmpty().WithMessage("Employee Name is required.")
                .Length(4, 100).WithMessage("Employee Name must be between 4 and 100 characters.");


        }
    }
}
