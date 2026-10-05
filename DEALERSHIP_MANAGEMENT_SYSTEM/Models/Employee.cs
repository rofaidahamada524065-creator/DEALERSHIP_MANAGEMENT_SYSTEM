using System.ComponentModel.DataAnnotations;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Employee
    {
        [Key]
        public int EmployeeId {  get; set; }
        [Required]
        [MaxLength(150)]
        public string FullName {  get; set; }
        [Required]
        [MaxLength(150)]
        public string Position {  get; set; }
        [Required]
        [EmailAddress]
        public string Email {  get; set; }
        [MaxLength(20)]
        public string? Phone {  get; set; }
        [Required]
        public DateTime HireDate { get; set; }

        public ICollection<Sale> sales { get; set; }=new List<Sale>();


    }
}
