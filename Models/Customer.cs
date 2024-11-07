using System.ComponentModel.DataAnnotations;

namespace P01_SalesDatabase.Models
{
    public class Customer
    {
        [Key]  
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(100)] 
        public string? Name { get; set; }

        [Required]
        [MaxLength(80)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [MaxLength(16)]
        public string? CreditCardNumber { get; set; }

        public double Sales { get; set; } 
    }
}
