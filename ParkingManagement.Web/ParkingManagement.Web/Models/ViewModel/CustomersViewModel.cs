using ParkingManagement.Web.DataAccess;

namespace ParkingManagement.Web.Models.ViewModel
{
    public class CustomersViewModel
    {
       public IEnumerable<Customer> Customers { get; set; }
       public Filter FilterSetting { get; set; }
    }
}
