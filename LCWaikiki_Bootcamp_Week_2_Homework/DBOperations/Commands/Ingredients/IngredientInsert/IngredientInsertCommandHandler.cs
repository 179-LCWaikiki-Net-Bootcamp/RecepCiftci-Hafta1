using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.IngredientRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Ingredients.IngredientInsert
{
    public class IngredientInsertCommandHandler : BaseInsertCommandHandler<IngredientDto>
    {
        private readonly IIngredientRepository _ingredientRepository;
        public IngredientInsertCommandHandler(IMapper mapper, IIngredientRepository ingredientRepository) : base(mapper)
        {
            _ingredientRepository = ingredientRepository;
        }

        public async override Task<ResponseDto<NoContent>> Handle(BaseInsertCommand<IngredientDto> request, CancellationToken cancellationToken)
        {
            await _ingredientRepository.Save(_mapper.Map<Ingredient>(request.entity));
            return await base.Handle(request, cancellationToken);
        }
    }
}