using AutoMapper;
using LCWaikiki_Bootcamp_Week_1_Homework.Core;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductDelete;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductInsert;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductUpdate;
using LCWaikiki_Bootcamp_Week_1_Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace LCWaikiki_Bootcamp_Week_1_Homework.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductRepository(ProductDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _dbContext.Products.FirstAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetProductsByPage(int page, int pageSize)
        {
            return await _dbContext.Products.Skip(page - 1 * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task SaveProduct(ProductInsertCommand command)
        {
            await _dbContext.AddAsync(_mapper.Map<Product>(command));
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProduct(ProductUpdateCommand command)
        {
            var product = _dbContext.Products.Single(p => p.Id == command.Id);

            if (product == null)
                throw new InvalidOperationException("Product that should be updated couldn't found");

            product.Name = command.Name;
            product.Price = command.Price;
            product.Stock = command.Stock;
            product.CategoryId = command.CategoryId;
            product.Color = command.Color;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProduct(ProductDeleteCommand command)
        {
            Product p = _dbContext.Products.Single(p => p.Id == command.Id);
            _dbContext.Remove(p);
            await _dbContext.SaveChangesAsync();
        }
    }
}
