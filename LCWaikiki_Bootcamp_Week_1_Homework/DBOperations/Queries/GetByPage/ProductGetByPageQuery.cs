using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Queries.GetByPage
{
    public class ProductGetByPageQuery : IRequest<ResponseDto<List<ProductDto>>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
