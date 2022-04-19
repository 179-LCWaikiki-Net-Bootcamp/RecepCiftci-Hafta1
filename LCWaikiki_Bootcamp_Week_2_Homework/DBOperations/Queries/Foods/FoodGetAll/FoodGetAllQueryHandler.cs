using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Bases.GetAll;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Queries.Foods.FoodGetAll
{
    public class FoodGetAllQueryHandler : GetAllQueryHandler<Food>
    {
        public FoodGetAllQueryHandler(IFoodRepository baseRepository, IMapper mapper) : base(baseRepository, mapper) { }
    }
}