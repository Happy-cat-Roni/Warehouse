using FluentValidation;
using WareHouseAPI.DTO;

namespace WareHouseAPI.FluentValidation
{
    public class DirectorValidation : AbstractValidator<DirectorDTO>
    {
        public DirectorValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required")
                .Length(3, 30).WithMessage("Must be in range 6-30");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required")
                .Length(3, 30).WithMessage("Must be in range 6-30");
        }

    }
}
