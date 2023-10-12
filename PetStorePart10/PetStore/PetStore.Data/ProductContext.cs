using Microsoft.EntityFrameworkCore;

namespace PetStore.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public string DbPath { get; set; }

        public ProductContext()
        {
            var path = Directory.GetCurrentDirectory();
            DbPath = Path.Join(path, "products.db");
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={DbPath}");
    }
}