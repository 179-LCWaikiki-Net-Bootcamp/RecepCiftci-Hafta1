using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Queries.GetById
{
    public class ProductGetByIdQuery : IRequest<ResponseDto<ProductDto>>
    {
        public int Id { get; set; }
    }
}
