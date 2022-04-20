using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetBySearch;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Foods.FoodGetBySearch
{
    public class FoodGetBySearchQueryHandler : GetBySearchQueryHandler<FoodViewModel>
    {
        private readonly IFoodRepository _foodRepository;

        public FoodGetBySearchQueryHandler(IMapper mapper, IFoodRepository foodRepository) : base(mapper)
        {
            _foodRepository = foodRepository;
        }
        public override async Task<ResponseDto<IReadOnlyList<FoodViewModel>>> Handle(GetBySearchQuery<FoodViewModel> request, CancellationToken cancellationToken)
        {
            _baseEntities = await _foodRepository.GetBySearch(request.Keyword);
            return await base.Handle(request, cancellationToken);
        }
    }
}
