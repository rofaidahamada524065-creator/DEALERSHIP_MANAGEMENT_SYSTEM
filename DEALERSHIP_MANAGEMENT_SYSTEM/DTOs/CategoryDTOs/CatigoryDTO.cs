using System.ComponentModel.DataAnnotations;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.DTOs.CategoryDTOs
{
    public class CatigoryDTO
    {
        public int CategoryId { get; set; }
       
        public string CategoryName { get; set; }
       
        public string? Description { get; set; }
    }
}
