using System.Collections.Generic;
using System.Web.Mvc;
using DomainModel;
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

        public ActionResult Index()
        {
            var products = _session.CreateCriteria<Product>().List<Product>();

            return this.AutoMapView<IEnumerable<Product>, IEnumerable<ProductViewModel>>(View(), products);
        }
    }
}