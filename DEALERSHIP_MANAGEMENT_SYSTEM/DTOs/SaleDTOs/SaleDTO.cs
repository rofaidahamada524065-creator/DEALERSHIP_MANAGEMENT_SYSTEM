using DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.SaleDTOs
{
    public class SaleDTO
    {
        public int SaleId { get; set; }

        public DateTime SaleDate { get; set; }
        
        public decimal SalePrice { get; set; }
    
        public string PaymentMethod { get; set; }
   
        public string? Notes { get; set; }

        public int CustomerId { get; set; }
   

        public int EmployeeId { get; set; }
     

        public int VehicleId { get; set; }
    }
}
