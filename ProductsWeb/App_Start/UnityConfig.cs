using Product.Core.Interface;
using Product.Core.Repository;
using ProductsWeb.Service;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ProductsWeb
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductsService, ProductsService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}