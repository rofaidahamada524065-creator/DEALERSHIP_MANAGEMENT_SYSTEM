using System.ComponentModel.DataAnnotations;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Models
{
    [Index(nameof(FullName), IsUnique = true)]
    [Index(nameof(DriverLicenseNumber), IsUnique = true)]
    public class Customer
    {
     
        [Key]
        public int CustomerId {  get; set; }
        [Required]
        [MaxLength(150)]
        public string FullName {  get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email {  get; set; }
        [Required]
        [MaxLength (20)]
        public string Phone { get; set; }
        [Required]
        [MaxLength (30)]

        public string DriverLicenseNumber {  get; set; }

        public ICollection<Sale> sales { get; set; }= new HashSet<Sale>();

        public CustomerProfile CustomerProfile { get; set; }
    }
}
