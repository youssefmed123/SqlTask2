using System.ComponentModel.DataAnnotations;

namespace P01_SalesDatabase.Models
{
    public class Sale
    {
        [Key] 
        public int SaleId { get; set; }

        [Required]
        public string? Product { get; set; } 

        [Required]
        public string? Customer { get; set; } 

        [Required]
        public string? Store { get; set; } 

        public string? SaleDate { get; set; } 
    }
}