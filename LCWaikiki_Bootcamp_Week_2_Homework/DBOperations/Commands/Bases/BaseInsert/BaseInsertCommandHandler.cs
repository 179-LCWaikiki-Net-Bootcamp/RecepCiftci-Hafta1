using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using MediatR;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert
{
    public class BaseInsertCommandHandler<T> : IRequestHandler<BaseInsertCommand<T>, ResponseDto<NoContent>> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseInsertCommandHandler(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<ResponseDto<NoContent>> Handle(BaseInsertCommand<T> request, CancellationToken cancellationToken)
        {
            await _baseRepository.Save(request.entity);
            return ResponseDto<NoContent>.Success(204);
        }
    }
}
