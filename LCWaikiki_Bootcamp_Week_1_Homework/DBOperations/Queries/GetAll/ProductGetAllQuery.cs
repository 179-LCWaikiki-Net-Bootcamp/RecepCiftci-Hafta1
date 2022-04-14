using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Queries.GetAll
{
    public class ProductGetAllQuery : IRequest<ResponseDto<List<ProductDto>>>
    {
    }
}
