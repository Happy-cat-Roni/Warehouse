using FluentValidation;
using WareHouseAPI.DTO;

namespace WareHouseAPI.FluentValidation
{
    public class EmployeeValidation : AbstractValidator<EmployeesDTO>
    {
        public EmployeeValidation() 
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(30).WithMessage("Must be less than 30");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required")
                .MaximumLength(30).WithMessage("Must be less than 30");

            RuleFor(x => x.Salary)
                .NotEmpty().WithMessage("Salary is required");
        }
    }
}
