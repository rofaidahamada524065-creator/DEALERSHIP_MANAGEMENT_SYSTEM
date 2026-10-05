namespace DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.VehicleDTOs
{
    public class UpdateVehicleDTO
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string? Color { get; set; }

        public decimal Price { get; set; }

        public string VIN { get; set; }

        public string? FuelType { get; set; }

        public string? Transmission { get; set; }

        public string Status { get; set; }


        public int CategoryId { get; set; }

        public int Mileage { get; set; }
    }
}
