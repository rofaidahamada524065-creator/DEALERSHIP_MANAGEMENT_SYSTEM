using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Models
{
    [Index(nameof(VIN), IsUnique = true)]
    public class Vehicle
    {
        //        Id int Primary key, auto-incremented
        //Make string Required, max 100
        //Model string Required, max 100
        //Year int Required
        //Color string Optional, max 50
        //Price decimal Required, &gt; 0; precision(12,2)
        //Mileage int Required, &gt;= 0
        //VIN string Required, max 17, unique
        //FuelType string Optional, max 30
        //Transmission string Optional, max 30
        //Status string Required; default Available
        [Key]
        public int VehicleId {  get; set; }
        [Required]
        [MaxLength(100)]
        public string Make { get; set; }
        [Required]
        [MaxLength(100)]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [MaxLength(50)]
        public string? Color {  get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public decimal Price {  get; set; }
        [Required]
        [MaxLength(17)]
        public string VIN { get; set; }
        [MaxLength(30)]
        public string? FuelType {  get; set; }
        [MaxLength(30)]
        public string? Transmission {  get; set; }  
        [Required]
        public string Status { get; set; }


        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category category { get; set; }

        public Sale Sale { get; set; }
        [Required]
        [Range(1,int.MaxValue)]

        public int Mileage {  get; set; }

    }
}
