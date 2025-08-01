using System.ComponentModel.DataAnnotations;

namespace ZOLShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;
        
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}