using System.ComponentModel.DataAnnotations;

namespace P01_SalesDatabase.Models
{
    public class Product
    {
        [Key] 
        public int ProductId { get; set; }

        [Required]
        [MaxLength(50)] 
        public string? Name { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public double Quantity { get; set; } 
        public double Price { get; set; }

        public double Sales { get; set; } 

        public string? Description { get; set; }
    }
}