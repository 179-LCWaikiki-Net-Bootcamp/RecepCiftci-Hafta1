using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseUpdate;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.IngredientRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Ingredients.IngredientUpdate
{
    public class IngredientUpdateCommandHandler : BaseUpdateCommandHandler<IngredientViewModel>
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientUpdateCommandHandler(IMapper mapper, IIngredientRepository ingredientRepository) : base(mapper)
        {
            _ingredientRepository = ingredientRepository;
        }

        public async override Task<ResponseDto<NoContent>> Handle(BaseUpdateCommand<IngredientViewModel> request, CancellationToken cancellationToken)
        {
            await _ingredientRepository.Update(_mapper.Map<Ingredient>(request));
            return await base.Handle(request, cancellationToken);
        }
    }
}
