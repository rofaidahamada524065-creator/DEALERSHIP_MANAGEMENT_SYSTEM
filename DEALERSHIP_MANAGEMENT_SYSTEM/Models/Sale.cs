using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Models
{
    public class Sale
    {
        [Key]
        public int SaleId {  get; set; }
        [Required]
        public DateTime SaleDate {  get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public decimal SalePrice {  get; set; }
        [Required]
        [MaxLength(30)]
        public string PaymentMethod {  get; set; }
        [MaxLength(300)]
        public string? Notes {  get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer customer { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee employee { get; set; }

        public int VehicleId { get; set; }
        [ForeignKey("VehicleId")]
        public Vehicle vehicle { get; set; }
    }
}
