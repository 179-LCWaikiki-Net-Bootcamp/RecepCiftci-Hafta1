using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseDelete
{
    public class BaseDeleteCommandHandler<T> : IRequestHandler<BaseDeleteCommand, ResponseDto<NoContent>> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseDeleteCommandHandler(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<ResponseDto<NoContent>> Handle(BaseDeleteCommand request, CancellationToken cancellationToken)
        {
            await _baseRepository.Delete(request.Id);
            return ResponseDto<NoContent>.Success(204);
        }
    }
}
