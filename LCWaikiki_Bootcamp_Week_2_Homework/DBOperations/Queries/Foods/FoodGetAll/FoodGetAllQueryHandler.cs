using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetAll;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Foods.FoodGetAll
{
    public class FoodGetAllQueryHandler : GetAllQueryHandler<FoodViewModel>
    {
        private readonly IFoodRepository _foodRepository;

        public FoodGetAllQueryHandler(IMapper mapper, IFoodRepository foodRepository) : base(mapper)
        {
            _foodRepository = foodRepository;
        }

        public override async Task<ResponseDto<IReadOnlyList<FoodViewModel>>> Handle(GetAllQuery<FoodViewModel> request, CancellationToken cancellationToken)
        {
            _baseEntities = await _foodRepository.GetAll();
            return await base.Handle(request, cancellationToken);
        }
    }
}