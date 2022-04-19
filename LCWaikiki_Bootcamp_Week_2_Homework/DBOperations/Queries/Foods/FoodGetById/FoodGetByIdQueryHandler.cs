using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetById;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Foods.FoodGetById
{
    public class FoodGetByIdQueryHandler : GetByIdQueryHandler<FoodDto>
    {
        private readonly IFoodRepository _foodRepository;
        public FoodGetByIdQueryHandler(IMapper mapper, IFoodRepository foodRepository) : base(mapper)
        {
            _foodRepository = foodRepository;
        }

        public override async Task<ResponseDto<FoodDto>> Handle(GetByIdQuery<FoodDto> request, CancellationToken cancellationToken)
        {
            _baseEntity = await _foodRepository.GetById(request.Id);
            return await base.Handle(request, cancellationToken);
        }
    }
}
