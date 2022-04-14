using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductDelete
{
    public class ProductDeleteCommand : IRequest<ResponseDto<string>>
    {
        public int Id { get; set; }
    }
}
