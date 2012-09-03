using System.Collections.Generic;
using System.Web.Mvc;
using DomainModel;
using MvcApplication1.Attributes;
using MvcApplication1.Extensions;
using MvcApplication1.Models;
using NHibernate;

namespace MvcApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ISession _session;

        public ProductController(ISession session)
        {
            _session = session;
        }

        [Transaction]
        public ActionResult Index()
        {
            var products = _session.CreateCriteria<Product>().List<Product>();

            return this.AutoMapView<IEnumerable<Product>, IEnumerable<ProductViewModel>>(View(), products);
        }

        public ActionResult ShowAdd()
        {
            return View();
        }

        [Transaction]
        public ActionResult SaveProduct(SaveProductViewModel saveProductViewModel)
        {
            //TODO: Need to create a mapper for this. Also a filter to add a transaction.
            _session.Save(new Product {Name = saveProductViewModel.Name, Price = saveProductViewModel.Price});

            return RedirectToAction("Index");
        }
    }
}