using Catalog.API.Models.Auditentitys;

namespace Catalog.API.Models
{
    public class Product : Auditentity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public string Summary { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
    }
}
