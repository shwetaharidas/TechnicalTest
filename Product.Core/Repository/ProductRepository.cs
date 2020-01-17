using Product.Core.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Product.Core.Repository
{
    public class ProductRepository : IProductRepository
    {
        ProductDbContext context = new ProductDbContext();
        public void Add(ProductEntity product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public IEnumerable<ProductEntity> GetAllProducts()
        {
            return context.Products.ToList();
        }
       
    }
}
