using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository
{
    public interface IFoodRepository : IBaseRepository<Food>
    {
        Task SaveFood(FoodDto dto);
    }
}
