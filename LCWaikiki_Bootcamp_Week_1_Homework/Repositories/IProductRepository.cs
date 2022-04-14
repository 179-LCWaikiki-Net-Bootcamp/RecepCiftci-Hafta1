using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductDelete;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductInsert;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductUpdate;
using LCWaikiki_Bootcamp_Week_1_Homework.Models;

namespace LCWaikiki_Bootcamp_Week_1_Homework.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetProductsByPage(int page, int pageSize);

        Task SaveProduct(ProductInsertCommand command);
        Task UpdateProduct(ProductUpdateCommand command);
        Task DeleteProduct(ProductDeleteCommand command);
    }
}