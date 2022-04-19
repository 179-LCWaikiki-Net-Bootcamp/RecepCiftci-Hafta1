using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Controllers
{
    public class FoodsController : CustomControllerBase<FoodDto>
    {
        public FoodsController(IMediator mediator) : base(mediator)
        {
        }
    }
}