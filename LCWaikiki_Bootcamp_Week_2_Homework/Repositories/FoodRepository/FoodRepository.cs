using LCWaikiki_Bootcamp_Week_2_Homework.Core;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository
{
    public class FoodRepository : BaseRepository<Food>, IFoodRepository
    {
        public FoodRepository(RestaurantDbContext context) : base(context) { }
    }
}