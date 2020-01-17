using System;
using System.Collections.Generic;
using System.Linq;
using Product.Core;
using Product.Core.Interface;
using ProductsWeb.Models;


namespace ProductsWeb.Service
{
    public class ProductsService : IProductsService
    {
        private readonly IProductRepository _productRepository;


        public ProductsService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public void AddProduct(ProductViewModel productViewModel)
        {
            try
            {
                if (productViewModel != null)
                {
                    //This model can be mapped to entity using automapper.
                    ProductEntity product = new ProductEntity();
                    product.Sku = productViewModel.Sku;
                    product.Price = productViewModel.Price;
                    product.Colour = productViewModel.Colour;
                    product.Stock = productViewModel.Stock;
                    product.Style = productViewModel.Style;
                    product.Title = productViewModel.Title;
                    this._productRepository.Add(product);
                }
            }
            catch (Exception ex)
            {
                //One can log the exception by implementing logging module.
                throw;
            }


        }

        public List<ProductViewModel> GetAllProducts()
        {
            List<ProductViewModel> modelList = new List<ProductViewModel>();
            try
            {
                IEnumerable<ProductEntity> modeldata = this._productRepository.GetAllProducts();
                if (modeldata.Count() > 0)
                {   
                    foreach (var model in modeldata)
                    {
                        ProductViewModel productmodel = new ProductViewModel();
                        productmodel.Sku = model.Sku;
                        productmodel.Colour = model.Colour;
                        productmodel.Price = model.Price;
                        productmodel.Price = model.Price;
                        productmodel.Stock = model.Stock;
                        productmodel.Style = model.Style;
                        productmodel.Title = model.Title;
                        modelList.Add(productmodel);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return modelList;
        }

        public bool IsSkuExists(string Sku)
        {
            return this._productRepository.GetAllProducts().Any(p => p.Sku == Sku);
        }
    }
}