using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert
{
    public class BaseInsertCommand<T> : IRequest<ResponseDto<NoContent>> where T : class
    {
        public T entity { get; set; }

    }
}