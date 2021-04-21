using Microsoft.EntityFrameworkCore;
using VillasenorAPI.Models;

namespace VillasenorAPI.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext>options): base(options)
        {

        }
        public DbSet<Customer> customerItems{get; set;}
        public DbSet<SellingCustomer> sellingCustomer {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasDiscriminator<string>("customer_type")
                .HasValue<Customer>("customer_base")
                .HasValue<SellingCustomer>("customer_selling");
        }
    }
}