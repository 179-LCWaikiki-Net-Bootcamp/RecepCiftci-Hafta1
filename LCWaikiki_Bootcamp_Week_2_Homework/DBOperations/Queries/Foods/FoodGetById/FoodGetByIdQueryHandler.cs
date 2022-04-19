using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetById;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Foods.FoodGetById
{
    public class FoodGetByIdQueryHandler : GetByIdQueryHandler<FoodDto>
    {
        public FoodGetByIdQueryHandler(IBaseRepository<FoodDto> baseRepository, IMapper mapper) : base(baseRepository, mapper) { }
    }
}
