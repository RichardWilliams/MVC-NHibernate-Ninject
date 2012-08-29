using System.Collections.Generic;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var productViewModel1 = new ProductViewModel(1, "Product1", 10);
            var productViewModel2 = new ProductViewModel(2, "Product2", 20);
            var productViewModel3 = new ProductViewModel(3, "Product3", 30);
            var productViewModels = new ProductsViewModel(new List<ProductViewModel>{productViewModel1, productViewModel2, productViewModel3});
            return View(productViewModels);
        }
    }
}