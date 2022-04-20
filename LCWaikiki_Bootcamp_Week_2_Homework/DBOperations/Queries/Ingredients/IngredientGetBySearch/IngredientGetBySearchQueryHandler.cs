using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetBySearch;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.IngredientRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Ingredients.IngredientGetBySearch
{
    public class IngredientGetBySearchQueryHandler : GetBySearchQueryHandler<IngredientViewModel>
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientGetBySearchQueryHandler(IMapper mapper, IIngredientRepository ingredientRepository) : base(mapper)
        {
            _ingredientRepository = ingredientRepository;
        }
        public override async Task<ResponseDto<IReadOnlyList<IngredientViewModel>>> Handle(GetBySearchQuery<IngredientViewModel> request, CancellationToken cancellationToken)
        {
            _baseEntities = await _ingredientRepository.GetBySearch(request.Keyword);
            return await base.Handle(request, cancellationToken);
        }
    }
}