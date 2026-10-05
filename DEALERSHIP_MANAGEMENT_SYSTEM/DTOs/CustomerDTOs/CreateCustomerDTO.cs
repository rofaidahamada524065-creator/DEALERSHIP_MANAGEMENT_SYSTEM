using System.ComponentModel.DataAnnotations;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.CustomerDTOs
{
    public class CreateCustomerDTO
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }


        public string DriverLicenseNumber { get; set; }

        public int CustomerProfileId { get; set; }
       
        public string Address { get; set; }
        
        public string? City { get; set; }
        
        public string? Nationality { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int CustomerId { get; set; }
    }
}
