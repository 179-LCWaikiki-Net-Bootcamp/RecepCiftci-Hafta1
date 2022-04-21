using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseDelete
{
    public abstract class BaseDeleteCommandHandler<T> : IRequestHandler<BaseDeleteCommand<T>, ResponseDto<NoContent>> where T : class
    {
        public virtual async Task<ResponseDto<NoContent>> Handle(BaseDeleteCommand<T> request, CancellationToken cancellationToken)
        {
            return ResponseDto<NoContent>.Success(204);
        }
    }
}
