using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseUpdate;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Foods.FoodUpdate
{
    public class FoodUpdateCommandHandler : BaseUpdateCommandHandler<FoodViewModel>
    {
        private readonly IFoodRepository _foodRepository;
        public FoodUpdateCommandHandler(IMapper mapper, IFoodRepository foodRepository) : base(mapper)
        {
            _foodRepository = foodRepository;
        }

        public async override Task<ResponseDto<NoContent>> Handle(BaseUpdateCommand<FoodViewModel> request, CancellationToken cancellationToken)
        {
            await _foodRepository.Update(_mapper.Map<Food>(request));
            return await base.Handle(request, cancellationToken);
        }
    }
}
