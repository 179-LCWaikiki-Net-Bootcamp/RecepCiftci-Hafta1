using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseDelete;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Foods.FoodDelete
{
    public class FoodDeleteCommandHandler : BaseDeleteCommandHandler<FoodViewModel>
    {
        private readonly IFoodRepository _foodRepository;
        public FoodDeleteCommandHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public async override Task<ResponseDto<NoContent>> Handle(BaseDeleteCommand<FoodViewModel> request, CancellationToken cancellationToken)
        {
            await _foodRepository.Delete(request.Id);
            return await base.Handle(request, cancellationToken);
        }
    }
}