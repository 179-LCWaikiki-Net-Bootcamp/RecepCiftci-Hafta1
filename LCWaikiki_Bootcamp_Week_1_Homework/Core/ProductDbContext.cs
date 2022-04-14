using LCWaikiki_Bootcamp_Week_1_Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace LCWaikiki_Bootcamp_Week_1_Homework.Core
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
