using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingManagement.Web.DataAccess
{
    public class Customer
    {
        [Key]
        public Guid InternalId { get; set; }

        [Required(ErrorMessage = "The Customer Id field is required.")]
        [MaxLength(20, ErrorMessage = "The Customer Id field must contain less than or equal to 20 characters.")]
        public string CustomerId { get; set; }

        [Required(ErrorMessage = "The First Name field is required.")]
        [MaxLength(20, ErrorMessage = "The First Name field must contain less than or equal to 20 characters.")]
        public string FirstName { get; set; }

        [MaxLength(20, ErrorMessage = "The Middle Name field must contain less than or equal to 20 characters.")]
        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "The Last Name field is required.")]
        [MaxLength(20, ErrorMessage = "The Last Name field must contain less than or equal to 20 characters.")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Please Select Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "The Contact No. field is required.")]
        [MaxLength(20, ErrorMessage = "The Contact No. field must contain less than or equal to 20 characters.")]
        public string ContactNo { get; set; }

        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "The Address field is required.")]
        public string Address { get; set; }

        public IEnumerable<Car>? Cars { get; set; }
    }
}
