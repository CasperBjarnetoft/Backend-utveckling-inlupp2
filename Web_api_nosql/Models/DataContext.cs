using Microsoft.EntityFrameworkCore;

namespace Web_api_nosql.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToContainer("ProductsCatalog").HasPartitionKey(x => x.Id);
        }
    }
}
