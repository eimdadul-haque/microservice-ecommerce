namespace Catalog.API.Models.DTO
{
    public class ProductDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Modified { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public string CreatedFrom { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public string Summary { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
    }
}
