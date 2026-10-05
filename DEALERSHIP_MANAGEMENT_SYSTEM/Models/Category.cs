using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Models
{
    [Index (nameof(CategoryName),IsUnique =true)]
    public class Category
    {

      
        [Key]
        public int CategoryId {  get; set; }
        [Required]
        [MaxLength(200)]
        public string CategoryName { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }

        public ICollection<Vehicle> vehicles { get; set; } = new List<Vehicle>();
    }
}
