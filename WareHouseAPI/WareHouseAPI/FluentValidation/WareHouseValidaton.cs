using FluentValidation;
using WareHouseAPI.DTO;

namespace WareHouseAPI.FluentValidation
{
    public class WareHouseValidaton : AbstractValidator<WareHouseDTO>
    {
        public WareHouseValidaton() 
        {
            RuleFor(x =>  x.Name)
                .NotEmpty().WithMessage("Name is required");

            RuleFor(x => x.Director)
                .NotEmpty().WithMessage("Director is required");
        }
    }
}
