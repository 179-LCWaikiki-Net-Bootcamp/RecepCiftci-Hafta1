using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert
{
    public class BaseInsertCommandHandler<T> : IRequestHandler<BaseInsertCommand<T>, ResponseDto<NoContent>> where T : class
    {
        protected readonly IMapper _mapper;

        public BaseInsertCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public virtual async Task<ResponseDto<NoContent>> Handle(BaseInsertCommand<T> request, CancellationToken cancellationToken)
        {
            //await _baseRepository.Save(request.entity);
            return ResponseDto<NoContent>.Success(201);
        }
    }
}
