using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetById
{
    public class GetByIdQuery<T> : IRequest<ResponseDto<T>> where T : BaseEntity
    {
        public int Id { get; set; }
    }
}
