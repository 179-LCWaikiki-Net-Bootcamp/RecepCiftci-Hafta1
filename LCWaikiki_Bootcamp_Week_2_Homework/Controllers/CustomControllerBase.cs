using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseDelete;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseUpdate;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetAll;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetById;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetBySearch;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomControllerBase<T, R> : ControllerBase
        where T : class
        where R : class
    {
        private readonly IMediator _mediator;

        public CustomControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllQuery<T>());
            return CreateActionResult(response);
        }

        // TODO Return error if id isn't exist
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _mediator.Send(new GetByIdQuery<T>() { Id = id });
            return CreateActionResult(response);
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetByPage(string keyword)
        {
            var response = await _mediator.Send(new GetBySearchQuery<T>() { Keyword = keyword });
            return CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(BaseInsertCommand<R> request)
        {
            if (ModelState.IsValid)
            {
                var response = await _mediator.Send(new BaseInsertCommand<R>() { entity = request.entity });
                return CreateActionResult(response);
            }
            return CreateActionResult(ResponseDto<NoContent>.Fail("Inputs are not valid", 404));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(BaseUpdateCommand<T> request)
        {
            var response = await _mediator.Send(request);
            return CreateActionResult(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] BaseDeleteCommand<T> request)
        {
            var response = await _mediator.Send(request);
            return CreateActionResult(response);
        }

        [NonAction] // Don't expose
        public IActionResult CreateActionResult<T>(ResponseDto<T> response)
        {
            // For swagger only. Not necessary for API
            if (response.StatusCode == 204)
                return new ObjectResult(null) { StatusCode = response.StatusCode };

            return new ObjectResult(response) { StatusCode = response.StatusCode };
        }
    }
}
