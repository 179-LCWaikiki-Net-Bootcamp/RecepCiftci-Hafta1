using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetAll
{
    public class GetAllQuery<T> : IRequest<ResponseDto<IReadOnlyList<T>>> where T : class
    {
    }
}
