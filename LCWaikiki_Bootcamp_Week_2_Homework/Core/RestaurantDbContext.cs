using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Core
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Food> Food { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }

        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) { }

    }
}
