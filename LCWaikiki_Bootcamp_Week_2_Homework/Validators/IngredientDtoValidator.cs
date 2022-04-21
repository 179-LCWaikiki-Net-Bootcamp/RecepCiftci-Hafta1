using FluentValidation;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Validators
{
    public class IngredientDtoValidator : AbstractValidator<IngredientDto>
    {
        public IngredientDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().MinimumLength(4);
            RuleFor(x => x.Description).NotNull().NotEmpty().MinimumLength(10);
            RuleFor(x => x.CategoryId).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}
