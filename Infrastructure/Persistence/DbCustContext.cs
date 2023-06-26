using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class DbCustContext : IdentityDbContext // DbContext 
    {
        public DbCustContext(DbContextOptions<DbCustContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Material> Materials { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Calculate> Calculates { get; set; }=null!;
        public DbSet<Order> Orders { get; set; }=null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Customer>
            //    (entity =>
            //    {
            //        entity.OwnsOne(c => c.Address);
            //    });
        }

    }
}
