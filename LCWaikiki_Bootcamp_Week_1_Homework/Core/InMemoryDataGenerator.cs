using LCWaikiki_Bootcamp_Week_1_Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace LCWaikiki_Bootcamp_Week_1_Homework.Core
{
    public class InMemoryDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProductDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<ProductDbContext>>()))
            {
                // Look for any book.
                if (context.Products.Any())
                {
                    return;   // Data was already seeded
                }

                context.Products.AddRange(
                    new Product()
                    {
                        Name = "Blue Jean",
                        CategoryId = 1,
                        Color = "Blue",
                        Price = 199.99M,
                        Stock = 30

                    },
                    new Product()
                    {
                        Name = "Green Men Shirt",
                        CategoryId = 3,
                        Color = "Green",
                        Price = 89.99M,
                        Stock = 70
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
