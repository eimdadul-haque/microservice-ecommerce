using Catalog.API.Models;

namespace Catalog.API.Services.ProductService
{
    public interface IProductService 
    {
        Task<Product> GetProductById(string Id);
        Task<List<Product>> 
    }
}
