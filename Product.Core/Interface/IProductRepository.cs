using System.Collections.Generic;

namespace Product.Core.Interface
{
    public interface IProductRepository
    {
        void Add(ProductEntity product);
        
        IEnumerable<ProductEntity> GetAllProducts(); 
        
    }
}
