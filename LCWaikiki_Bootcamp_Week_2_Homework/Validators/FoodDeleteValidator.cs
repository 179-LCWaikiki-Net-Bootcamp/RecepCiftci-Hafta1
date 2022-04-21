using FluentValidation;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseDelete;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Validators
{
    public class FoodDeleteValidator : AbstractValidator<BaseDeleteCommand<FoodDto>>
    {
        public FoodDeleteValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull().GreaterThan(0);
        }
    }
}
