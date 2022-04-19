using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using System.Linq.Expressions;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAll();
        Task<T> GetById(int id);
        Task<IReadOnlyList<T>> GetBySearch(string keyword);
        Task<IReadOnlyList<T>> GetByPage(int page, int pageSize);

        Task Save(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}