using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductDelete;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductInsert;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductUpdate;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Queries.GetAll;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Queries.GetById;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Queries.GetByPage;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LCWaikiki_Bootcamp_Week_1_Homework.Controllers
{
    public class ProductsController : CustomControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var response = await _mediator.Send(new ProductGetAllQuery());
            return CreateActionResult(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var response = await _mediator.Send(new ProductGetByIdQuery() { Id = id });
            return CreateActionResult(response);
        }

        [HttpGet("{page}/{pageSize}")]
        public async Task<IActionResult> GetProductsByPage(int page, int pageSize)
        {
            var response = await _mediator.Send(new ProductGetByPageQuery() { Page = page, PageSize = pageSize });
            return CreateActionResult(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductInsertCommand request)
        {
            var response = await _mediator.Send(request);
            return CreateActionResult(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductUpdateCommand request)
        {
            var response = await _mediator.Send(request);
            return CreateActionResult(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct([FromQuery] ProductDeleteCommand request)
        {
            var response = await _mediator.Send(request);
            return CreateActionResult(response);
        }
    }
}
