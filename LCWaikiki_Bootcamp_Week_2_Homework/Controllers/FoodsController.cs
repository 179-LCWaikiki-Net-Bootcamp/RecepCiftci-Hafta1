using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Controllers
{
    public class FoodsController : CustomControllerBase<FoodViewModel, FoodDto>
    {
        public FoodsController(IMediator mediator) : base(mediator)
        {
        }
    }
}