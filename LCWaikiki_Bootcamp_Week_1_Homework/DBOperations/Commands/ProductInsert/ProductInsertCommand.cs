using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductInsert
{
    public class ProductInsertCommand : IRequest<ResponseDto<string>>
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}
