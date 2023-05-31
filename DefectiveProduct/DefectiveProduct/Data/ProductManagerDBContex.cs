using Microsoft.EntityFrameworkCore;

namespace DefectiveProduct.Data
{
    public class ProductManagerDBContex : DbContext
    {
        public ProductManagerDBContex(DbContextOptions<ProductManagerDBContex> options) 
            : base(options)
        {
        }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Manufacturer> Manufacturers { get; set; }
        public DbSet<Models.Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            /*
            modelBuilder.Entity<Models.Product>().ToTable("Product");
            modelBuilder.Entity<Models.Manufacturer>().ToTable("Manufacturer");
            modelBuilder.Entity<Models.Supplier>().ToTable("Supplier");
            */
        }
    }
}
