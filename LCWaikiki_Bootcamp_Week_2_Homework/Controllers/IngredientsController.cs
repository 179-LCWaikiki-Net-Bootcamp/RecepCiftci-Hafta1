using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Controllers
{
    public class IngredientsController : CustomControllerBase<IngredientViewModel, IngredientDto>
    {
        public IngredientsController(IMediator mediator) : base(mediator)
        {
        }
    }
}