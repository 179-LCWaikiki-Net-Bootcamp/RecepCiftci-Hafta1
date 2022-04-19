using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetAll
{
    public abstract class GetAllQueryHandler<T> : IRequestHandler<GetAllQuery<T>, ResponseDto<IReadOnlyList<T>>> 
        where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;
        private readonly IMapper _mapper;

        public GetAllQueryHandler(IBaseRepository<T> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<IReadOnlyList<T>>> Handle(GetAllQuery<T> request, CancellationToken cancellationToken)
        {
            //return new ResponseDto<IReadOnlyList<T>>() {StatusCode = 6000, Errors = new List<string>() { "RECEP" } };
            var response = await _baseRepository.GetAll();
            return ResponseDto<IReadOnlyList<T>>.Success(response, 200);
        }
    }
}
