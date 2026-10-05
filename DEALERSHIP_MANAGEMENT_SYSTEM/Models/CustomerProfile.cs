using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Models
{
    public class CustomerProfile
    {
        //        Id int Primary key, auto-incremented
        //Address string Required, max 250
        //City string Optional, max 100
        //Nationality string Optional, max 50
        //DateOfBirth DateTime Optional

        [Key]
        public int CustomerProfileId {  get; set; }
        [Required]
        [MaxLength(250)]
        public string Address {  get; set; }
        [MaxLength(100)]
        public string? City { get; set; }
        [MaxLength(50)]
        public string? Nationality {  get; set; }

        public DateTime? DateOfBirth {  get; set; }

        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

    }
}
