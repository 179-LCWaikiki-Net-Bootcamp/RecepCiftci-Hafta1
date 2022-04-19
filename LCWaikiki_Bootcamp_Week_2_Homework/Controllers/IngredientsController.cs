using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Controllers
{
    public class IngredientsController : CustomControllerBase<Ingredient>
    {
        public IngredientsController(IMediator mediator) : base(mediator)
        {
        }
    }
}
