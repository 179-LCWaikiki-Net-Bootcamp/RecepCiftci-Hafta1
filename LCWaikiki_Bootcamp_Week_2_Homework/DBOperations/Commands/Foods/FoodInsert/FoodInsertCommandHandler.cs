using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Foods.FoodInsert
{
    public class FoodInsertCommandHandler : BaseInsertCommandHandler<FoodDto>
    {
        private readonly IFoodRepository _foodRepository;
        public FoodInsertCommandHandler(IMapper mapper, IFoodRepository foodRepository) : base(mapper)
        {
            _foodRepository = foodRepository;
        }

        public async override Task<ResponseDto<NoContent>> Handle(BaseInsertCommand<FoodDto> request, CancellationToken cancellationToken)
        {
            await _foodRepository.SaveFood((request.entity));
            return await base.Handle(request, cancellationToken);
        }
    }
}
