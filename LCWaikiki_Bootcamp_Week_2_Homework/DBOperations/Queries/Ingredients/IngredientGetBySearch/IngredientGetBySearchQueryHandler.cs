using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetBySearch;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Ingredients.IngredientGetBySearch
{
    public class IngredientGetBySearchQueryHandler : GetBySearchQueryHandler<IngredientDto>
    {
        public IngredientGetBySearchQueryHandler(IBaseRepository<IngredientDto> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
