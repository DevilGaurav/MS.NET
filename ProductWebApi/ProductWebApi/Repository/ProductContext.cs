using Microsoft.EntityFrameworkCore;
using ProductWebApi.Entities;

namespace ProductWebApi.Repository
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = @"server=localhost;port=3306;user=root;password=root;database=ProductDotNet";
            optionsBuilder.UseMySQL(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(prod =>
            {
                prod.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Product>().ToTable("Product");

        }
    }
}
