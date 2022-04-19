using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetBySearch;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Foods.FoodGetBySearch
{
    public class FoodGetBySearchQueryHandler : GetBySearchQueryHandler<FoodDto>
    {
        public FoodGetBySearchQueryHandler(IBaseRepository<FoodDto> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
