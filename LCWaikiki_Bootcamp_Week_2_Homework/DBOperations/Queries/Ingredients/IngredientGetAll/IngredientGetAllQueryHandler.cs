using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetAll;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.IngredientRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Ingredients.IngredientGetAll
{
    public class IngredientGetAllQueryHandler : GetAllQueryHandler<Ingredient>
    {
        public IngredientGetAllQueryHandler(IIngredientRepository baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }
    }
}
