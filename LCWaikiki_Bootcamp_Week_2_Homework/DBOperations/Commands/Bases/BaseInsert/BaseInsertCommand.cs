using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert
{
    public class BaseInsertCommand<T> : IRequest<ResponseDto<NoContent>> where T : BaseEntity
    {
        public T entity { get; set; }

    }
}
