using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingManagement.Web.DataAccess
{
    public class Car
    {
        [Key]
        public Guid InternalId { get; set; }
        [ForeignKey("FK_Customer")]
        public Guid Customer_InternalId { get; set; }
        [Required, MaxLength(15)]
        public string CarId { get; set; }
        [Required, MaxLength(20)]
        public string PlateNo { get; set; }
        public string Make { get; set; }
        public string Series { get; set; }
        public string BodyType { get; set; }
        public string YearModel { get; set; }
        public string Color { get; set; }
        public IEnumerable<Car>? Cars { get; set; }
    }
}
