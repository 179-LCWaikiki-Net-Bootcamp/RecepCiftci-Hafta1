using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseDelete;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.IngredientRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Ingredients.IngredientDelete
{
    public class IngredientDeleteCommandHandler : BaseDeleteCommandHandler<IngredientDto>
    {
        private readonly IIngredientRepository _ingredientRepository;
        public IngredientDeleteCommandHandler(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public override Task<ResponseDto<NoContent>> Handle(BaseDeleteCommand<IngredientDto> request, CancellationToken cancellationToken)
        {

            return base.Handle(request, cancellationToken);
        }
    }
}
