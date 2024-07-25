using AzureAPI.Entity;
using Microsoft.EntityFrameworkCore;

namespace AzureAPI
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(x => x.Orders)
                .WithOne(y => y.Customer);

            modelBuilder.Entity<Order>()
                .HasOne(x => x.Customer)
                .WithMany(y => y.Orders);
        }
    }
}
