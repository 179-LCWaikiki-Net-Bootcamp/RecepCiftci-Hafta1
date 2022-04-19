using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetBySearch
{
    public class GetBySearchQueryHandler<T> : IRequestHandler<GetBySearchQuery<T>, ResponseDto<IReadOnlyList<T>>> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;
        private readonly IMapper _mapper;

        public GetBySearchQueryHandler(IBaseRepository<T> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<IReadOnlyList<T>>> Handle(GetBySearchQuery<T> request, CancellationToken cancellationToken)
        {
            var response = await _baseRepository.GetBySearch(x => x.Name.Contains(request.Keyword));
            return ResponseDto<IReadOnlyList<T>>.Success(response, 200);
        }
    }
}
