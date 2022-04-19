using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Controllers
{
    public class FoodsController : CustomControllerBase<Food>
    {
        public FoodsController(IMediator mediator) : base(mediator)
        {
        }
    }
}