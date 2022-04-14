using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductUpdate
{
    public class ProductUpdateCommand : IRequest<ResponseDto<string>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}
