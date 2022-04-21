using FluentValidation;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Validators
{
    public class FoodInsertValidator : AbstractValidator<BaseInsertCommand<FoodDto>>
    {
        public FoodInsertValidator()
        {
            RuleFor(x => x.entity).SetValidator(new FoodDtoValidator());
        }
    }
}
