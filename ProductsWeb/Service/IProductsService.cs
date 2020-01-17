using ProductsWeb.Models;
using System.Collections.Generic;

namespace ProductsWeb.Service
{
    public interface IProductsService
    {
        List<ProductViewModel> GetAllProducts();
        void AddProduct(ProductViewModel productViewModel);

        bool IsSkuExists(string Sku);
    }
}