using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Data
{
    public class Customer
    {
        [Key]
        public Guid InternalId { get; set; }
        [Required, MaxLength(20)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required, MaxLength(20)]
        public string LastName { get; set; }
        [Column(TypeName="Date")]
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        [Required, MaxLength(20)]
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public IEnumerable<Car> Cars { get; set; } 
    }
}
