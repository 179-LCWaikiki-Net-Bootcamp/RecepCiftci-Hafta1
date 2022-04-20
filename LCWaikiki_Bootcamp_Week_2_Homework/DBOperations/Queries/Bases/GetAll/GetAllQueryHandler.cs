using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetAll
{
    public abstract class GetAllQueryHandler<T> : IRequestHandler<GetAllQuery<T>, ResponseDto<IReadOnlyList<T>>>
        where T : class
    {
        protected readonly IMapper _mapper;
        protected IReadOnlyList<BaseEntity> _baseEntities { get; set; }

        public GetAllQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public virtual async Task<ResponseDto<IReadOnlyList<T>>> Handle(GetAllQuery<T> request, CancellationToken cancellationToken)
        {
            return ResponseDto<IReadOnlyList<T>>.Success(_mapper.Map<IReadOnlyList<T>>(_baseEntities), 200);
        }
    }
}