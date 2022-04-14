using FluentValidation;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductInsert;

namespace LCWaikiki_Bootcamp_Week_1_Homework.Validators
{
    public class ProductInsertValidator : AbstractValidator<ProductInsertCommand>
    {
        public ProductInsertValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name field can't be null");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Name field length should be more than 4");

            RuleFor(x => x.Price).NotEmpty().GreaterThan(0);
            RuleFor(x => x.Stock).NotEmpty().InclusiveBetween(1, int.MaxValue);
            RuleFor(x => x.Color).NotNull().MinimumLength(2).WithMessage("Color fied length should be more than 1");
            RuleFor(x => x.CategoryId).NotEmpty().GreaterThan(0);
        }
    }
}
