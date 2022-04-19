using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetById;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Ingredients.IngredientGetById
{
    public class IngredientGetByIdQueryHandler : GetByIdQueryHandler<IngredientDto>
    {
        public IngredientGetByIdQueryHandler(IBaseRepository<IngredientDto> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
