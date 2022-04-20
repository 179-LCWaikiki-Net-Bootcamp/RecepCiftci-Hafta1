using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetById;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.IngredientRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Ingredients.IngredientGetById
{
    public class IngredientGetByIdQueryHandler : GetByIdQueryHandler<IngredientViewModel>
    {
        private readonly IIngredientRepository _repository;

        public IngredientGetByIdQueryHandler(IMapper mapper, IIngredientRepository repository) : base(mapper)
        {
            _repository = repository;
        }

        public async override Task<ResponseDto<IngredientViewModel>> Handle(GetByIdQuery<IngredientViewModel> request, CancellationToken cancellationToken)
        {
            _baseEntity = await _repository.GetById(request.Id);
            return await base.Handle(request, cancellationToken);
        }
    }
}
