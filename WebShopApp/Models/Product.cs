using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
