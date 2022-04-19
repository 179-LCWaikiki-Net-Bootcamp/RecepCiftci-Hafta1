using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetById
{
    public class GetByIdQueryHandler<T> : IRequestHandler<GetByIdQuery<T>, ResponseDto<T>> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;
        private readonly IMapper _mapper;

        public GetByIdQueryHandler(IBaseRepository<T> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<T>> Handle(GetByIdQuery<T> request, CancellationToken cancellationToken)
        {
            var response = await _baseRepository.GetById(request.Id);
            return ResponseDto<T>.Success(response, 200);
        }
    }
}
