using LCWaikiki_Bootcamp_Week_2_Homework.Core;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Repositories.FoodRepository
{
    public class FoodRepository : BaseRepository<Food>, IFoodRepository
    {
        public FoodRepository(RestaurantDbContext context) : base(context) { }

        public async Task SaveFood(FoodDto dto)
        {
            Food food = new Food()
            {
                Name = dto.Name,
                Price = dto.Price,
                Description = dto.Description,
                CategoryId = dto.CategoryId,
                Ingredients = await _context.Ingredient.Where(i => dto.IngredientIds.Contains(i.Id)).ToListAsync()
            };
            await _context.Set<Food>().AddAsync(food);
            await _context.SaveChangesAsync();
        }

        public async override Task<IReadOnlyList<Food>> GetAll()
        {
            var foods = await _context.Food.Include(f => f.Ingredients).ToListAsync();
            return foods;
        }
    }
}