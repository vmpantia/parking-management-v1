using ParkingManagement.Web.DataAccess;

namespace ParkingManagement.Web.Models.ViewModel
{
    public class CustomerViewModel
    {
       public Customer inputCustomer { get; set; }
       public IEnumerable<string> Genders { 
            get {
                return new List<string>()
                {
                    "MALE",
                    "FEMALE"
                };
            } 
        }
    }
}
