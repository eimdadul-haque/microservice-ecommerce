using System.ComponentModel.DataAnnotations;

namespace Catalog.API.Models.Auditentitys
{
    public class Auditentity
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Modified { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public string CreatedFrom { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

    }
}
