using System.Configuration;
using System.Data.Entity;

namespace Product.Core
{
    class ProductDbContext : DbContext
    {
        private static string ProductDbConnectionString = ConfigurationManager.ConnectionStrings["ProductDbConnectionString"].ConnectionString;
        public ProductDbContext(): base(ProductDbConnectionString)
        {

        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
