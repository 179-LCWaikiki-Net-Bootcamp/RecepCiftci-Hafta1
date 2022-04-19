using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetBySearch
{
    public abstract class GetBySearchQueryHandler<T> : IRequestHandler<GetBySearchQuery<T>, ResponseDto<IReadOnlyList<T>>> where T : BaseEntity
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
