using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Controllers
{
    public class IngredientsController : CustomControllerBase<IngredientDto>
    {
        public IngredientsController(IMediator mediator) : base(mediator)
        {
        }
    }
}