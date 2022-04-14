using FluentValidation.AspNetCore;
using LCWaikiki_Bootcamp_Week_1_Homework.Validators;

namespace LCWaikiki_Bootcamp_Week_1_Homework.Services
{
    public static class FluentService
    {
        public static void AddFluentValidationServices(this IServiceCollection services)
        {
            services.AddControllers().AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<ProductDeleteValidator>()).AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<ProductInsertValidator>()).AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<ProductUpdateValidator>()).AddFluentValidation();
        }
    }
}
