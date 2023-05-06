namespace Catalog.API.Repositories.BaseRepositotys
{
    public interface IBaseRepositoty<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(string id);
        Task<T> GetById(string id);
        Task<bool> Save();
    }
}
