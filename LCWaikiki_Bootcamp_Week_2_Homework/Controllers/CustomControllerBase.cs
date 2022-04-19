using Microsoft.AspNetCore.Mvc;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetAll;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomControllerBase<T> : ControllerBase 
        where T : BaseEntity
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

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var response = await _mediator.Send( )
        //    //var response = await _mediator.Send(new ProductGetAllQuery());
        //    return CreateActionResult(response);
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetProductById(int id)
        //{
        //    var response = await _mediator.Send(new ProductGetByIdQuery() { Id = id });
        //    return CreateActionResult(response);
        //}

        //[HttpGet("{page}/{pageSize}")]
        //public async Task<IActionResult> GetProductsByPage(int page, int pageSize)
        //{
        //    var response = await _mediator.Send(new ProductGetByPageQuery() { Page = page, PageSize = pageSize });
        //    return CreateActionResult(response);
        //}

        //[HttpPost]
        //public async Task<IActionResult> AddProduct(ProductInsertCommand request)
        //{
        //    var response = await _mediator.Send(request);
        //    return CreateActionResult(response);
        //}

        //[HttpPut]
        //public async Task<IActionResult> UpdateProduct(ProductUpdateCommand request)
        //{
        //    var response = await _mediator.Send(request);
        //    return CreateActionResult(response);
        //}

        //[HttpDelete]
        //public async Task<IActionResult> DeleteProduct([FromQuery] ProductDeleteCommand request)
        //{
        //    var response = await _mediator.Send(request);
        //    return CreateActionResult(response);
        //}

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
