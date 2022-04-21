using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseUpdate
{
    public class BaseUpdateCommand<T> : IRequest<ResponseDto<NoContent>> where T : class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}