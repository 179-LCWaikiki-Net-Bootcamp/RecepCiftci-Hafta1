using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetBySearch
{
    public class GetBySearchQuery<T> : IRequest<ResponseDto<IReadOnlyList<T>>> where T : class
    {
        public string Keyword { get; set; }
    }
}
