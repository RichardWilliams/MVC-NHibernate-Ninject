using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using DomainModel;
using MvcApplication1.Attributes;
using MvcApplication1.Common;
using MvcApplication1.Extensions;
using MvcApplication1.Models;
using NHibernate;
using Ninject.Extensions.Logging;

namespace MvcApplication1.Controllers
{
    public class ProductController : Controller, IHaveALogger
    {
        private readonly ISession _session;
        private readonly ILogger _logger;

        public ProductController(ISession session, ILogger logger)
        {
            _session = session;
            _logger = logger;
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
            _session.Save(Mapper.Map<SaveProductViewModel, Product>(saveProductViewModel));

            return RedirectToAction("Index");
        }

        public ILogger Logger()
        {
            return _logger;
        }
    }
}