using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetAll;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.IngredientRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Ingredients.IngredientGetAll
{
    public class FoodGetAllQueryHandler : GetAllQueryHandler<IngredientViewModel>
    {
        private readonly IIngredientRepository _ingredientRepository;

        public FoodGetAllQueryHandler(IMapper mapper, IIngredientRepository ingredientRepository) : base(mapper)
        {
            _ingredientRepository = ingredientRepository;
        }

        public override async Task<ResponseDto<IReadOnlyList<IngredientViewModel>>> Handle(GetAllQuery<IngredientViewModel> request, CancellationToken cancellationToken)
        {
            _baseEntities = await _ingredientRepository.GetAll();
            return await base.Handle(request, cancellationToken);
        }
    }
}
