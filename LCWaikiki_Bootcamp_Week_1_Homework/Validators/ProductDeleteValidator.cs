using FluentValidation;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductDelete;

namespace LCWaikiki_Bootcamp_Week_1_Homework.Validators
{
    public class ProductDeleteValidator : AbstractValidator<ProductDeleteCommand>
    {
        public ProductDeleteValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id can't be empty");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id should be bigger than 0");
        }
    }
}
