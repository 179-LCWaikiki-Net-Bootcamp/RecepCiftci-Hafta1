using FluentValidation;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseUpdate;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Validators
{
    public class FoodUpdateValidator : AbstractValidator<BaseUpdateCommand<FoodDto>>
    {
        public FoodUpdateValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().MinimumLength(4);
            RuleFor(x => x.Description).NotNull().NotEmpty().MinimumLength(10);
        }
    }
}
