namespace DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.SaleDTOs
{
    public class CreateSaleDTO
    {
        public DateTime SaleDate { get; set; }

        public decimal SalePrice { get; set; }

        public string PaymentMethod { get; set; }

        public string? Notes { get; set; }

        public int CustomerId { get; set; }


        public int EmployeeId { get; set; }


        public int VehicleId { get; set; }
    }
}
