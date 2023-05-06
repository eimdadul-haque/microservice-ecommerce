using Catalog.API.Data;
using Catalog.API.Models;
using Catalog.API.Repositories.BaseRepositotys;

namespace Catalog.API.Repositories.ProductRepositoty
{
    public class ProductRepositoty : BaseRepositoty<Product>, IProductRepositoty
    {
        private CatalogDbContext _context;
        public ProductRepositoty(CatalogDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
