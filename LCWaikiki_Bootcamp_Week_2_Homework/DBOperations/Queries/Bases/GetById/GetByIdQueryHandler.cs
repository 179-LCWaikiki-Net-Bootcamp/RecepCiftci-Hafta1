using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetById
{
    public abstract class GetByIdQueryHandler<T> : IRequestHandler<GetByIdQuery<T>, ResponseDto<T>> where T : class
    {
        private readonly IMapper _mapper;
        protected BaseEntity _baseEntity { get; set; }

        public GetByIdQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public virtual async Task<ResponseDto<T>> Handle(GetByIdQuery<T> request, CancellationToken cancellationToken)
        {
            return ResponseDto<T>.Success(_mapper.Map<T>(_baseEntity), 200);
        }
    }
}
