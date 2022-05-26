using demo1.Models;
using Microsoft.EntityFrameworkCore;

namespace demo1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) {}

        public DbSet<Customer> Customers { get; set; }
    }
}
