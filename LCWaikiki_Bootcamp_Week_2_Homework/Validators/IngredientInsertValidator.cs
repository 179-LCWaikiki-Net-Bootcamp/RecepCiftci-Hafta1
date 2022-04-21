using FluentValidation;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Validators
{
    public class IngredientInsertValidator : AbstractValidator<BaseInsertCommand<IngredientDto>>
    {
        public IngredientInsertValidator()
        {
            RuleFor(x => x.entity).SetValidator(new IngredientDtoValidator());
        }
    }
}
