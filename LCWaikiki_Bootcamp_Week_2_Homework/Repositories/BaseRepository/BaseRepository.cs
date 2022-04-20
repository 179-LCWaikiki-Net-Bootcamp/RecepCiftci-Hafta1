using LCWaikiki_Bootcamp_Week_2_Homework.Core;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly RestaurantDbContext _context;

        public BaseRepository(RestaurantDbContext context)
        {
            _context = context;
        }

        public virtual async Task<IReadOnlyList<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetBySearch(string keyword)
        {
            return await _context.Set<T>().Where(x => x.Name.Contains(keyword)).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetByPage(int page, int pageSize)
        {
            return await _context.Set<T>().Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public virtual async Task Save(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public virtual async Task Delete(int id)
        {
            var deleted = _context.Set<T>().Where(x => x.Id == id);
            if (deleted.Count() == 0)
                throw new ArgumentOutOfRangeException("404", $"Element with ID {id} isn't exist");
            _context.Set<T>().Remove(deleted.First());
            await _context.SaveChangesAsync();
        }
    }
}