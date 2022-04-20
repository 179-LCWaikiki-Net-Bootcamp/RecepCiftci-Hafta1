using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseUpdate
{
    public class BaseUpdateCommandHandler<T> : IRequestHandler<BaseUpdateCommand<T>, ResponseDto<NoContent>> where T : class
    {
        protected readonly IMapper _mapper;
        public BaseUpdateCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public virtual async Task<ResponseDto<NoContent>> Handle(BaseUpdateCommand<T> request, CancellationToken cancellationToken)
        {
            return ResponseDto<NoContent>.Success(204);
        }
    }
}
