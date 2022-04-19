using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseDelete;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Ingredients.IngredientDelete
{
    public class IngredientDeleteCommandHandler : BaseDeleteCommandHandler<IngredientDto>
    {
        public IngredientDeleteCommandHandler(IBaseRepository<IngredientDto> baseRepository) : base(baseRepository)
        {
        }
    }
}
