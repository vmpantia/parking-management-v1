using Microsoft.EntityFrameworkCore;

namespace Web.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext() : base() { }
        public DataDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
    }
}
