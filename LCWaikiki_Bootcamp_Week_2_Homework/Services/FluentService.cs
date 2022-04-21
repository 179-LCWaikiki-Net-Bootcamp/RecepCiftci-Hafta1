using FluentValidation.AspNetCore;
using LCWaikiki_Bootcamp_Week_2_Homework.Validators;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Services
{
    public static class FluentService
    {
        public static void AddFluentValidationServices(this IServiceCollection services)
        {
            services.AddControllers().AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<FoodDeleteValidator>()).AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<FoodInsertValidator>()).AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<FoodUpdateValidator>()).AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<IngredientDeleteValidator>()).AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<IngredientInsertValidator>()).AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<FoodDtoValidator>()).AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<IngredientDtoValidator>()).AddFluentValidation(
                a => a.RegisterValidatorsFromAssemblyContaining<IngredientUpdateValidator>());
        }
    }
}
