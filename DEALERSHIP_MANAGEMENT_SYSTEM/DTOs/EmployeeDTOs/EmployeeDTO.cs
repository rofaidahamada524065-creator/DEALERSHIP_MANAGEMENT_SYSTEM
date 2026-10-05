using System.ComponentModel.DataAnnotations;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.EmployeeDTOs
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
   
        public string FullName { get; set; }
       
        public string Position { get; set; }
     
        public string Email { get; set; }
      
        public string? Phone { get; set; }
      
        public DateTime HireDate { get; set; }

    }
}
