using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Ingredients.IngredientInsert
{
    public class IngredientInsertCommandHandler : BaseInsertCommandHandler<IngredientDto>
    {
        public IngredientInsertCommandHandler(IBaseRepository<IngredientDto> baseRepository) : base(baseRepository)
        {
        }
    }
}
