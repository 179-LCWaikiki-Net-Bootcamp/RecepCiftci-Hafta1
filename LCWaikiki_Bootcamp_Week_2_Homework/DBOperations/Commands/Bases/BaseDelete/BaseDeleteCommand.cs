using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseDelete
{
    public class BaseDeleteCommand<T> : IRequest<ResponseDto<NoContent>> where T : class
    {
        public int Id { get; set; }
    }
}
