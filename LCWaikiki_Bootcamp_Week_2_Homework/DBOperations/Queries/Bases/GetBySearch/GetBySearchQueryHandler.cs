using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetBySearch
{
    public abstract class GetBySearchQueryHandler<T> : IRequestHandler<GetBySearchQuery<T>, ResponseDto<IReadOnlyList<T>>> where T : class
    {
        private readonly IMapper _mapper;
        protected IReadOnlyList<BaseEntity> _baseEntities { get; set; }

        public GetBySearchQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public virtual async Task<ResponseDto<IReadOnlyList<T>>> Handle(GetBySearchQuery<T> request, CancellationToken cancellationToken)
        {
            return ResponseDto<IReadOnlyList<T>>.Success(_mapper.Map<IReadOnlyList<T>>(_baseEntities), 200);
        }
    }
}
