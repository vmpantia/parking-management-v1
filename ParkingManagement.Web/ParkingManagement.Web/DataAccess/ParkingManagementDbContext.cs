using Microsoft.EntityFrameworkCore;

namespace ParkingManagement.Web.DataAccess
{
    public class ParkingManagementDbContext : DbContext
    {
        public ParkingManagementDbContext() : base() { }
        public ParkingManagementDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
    }
}
