using ProductsWeb.Models;
using ProductsWeb.Service;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProductsWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;
        
        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        // GET: Products
        public ActionResult Index()
        {
            List<ProductViewModel> productList = this.productsService.GetAllProducts();
            return View(productList);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            try
            {
                if (ModelState.IsValid) {
                    this.productsService.AddProduct(productViewModel);
                    return RedirectToAction("Index", "Products");
                }
                return View();
            }
            catch
            {
                return View("Error");
            }
        }

        public JsonResult SkuExist(string Sku) {
            if (!this.productsService.IsSkuExists(Sku))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

    }
}
