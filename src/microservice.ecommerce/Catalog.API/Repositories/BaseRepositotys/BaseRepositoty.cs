using Catalog.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Repositories.BaseRepositotys
{
    public class BaseRepositoty<T> : IBaseRepositoty<T> where T : class
    {
        private CatalogDbContext _context;

        public BaseRepositoty(CatalogDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public async Task DeleteAsync(string id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
                _context.Set<T>().Remove(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(string id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<bool> Save()
        {
            if (await _context.SaveChangesAsync() > 0)
                return true;
            else
                return false;
        }
    }
}
