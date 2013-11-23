using System.Collections.Generic;
using DomainModel;
using Moq;
using MvcApplication1.AutoMappings;
using MvcApplication1.Controllers;
using MvcApplication1.Models;
using NHibernate;
using Xunit;

namespace MvcApplication.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Index_Then_View_Is_AutoMapView_Of_EnumearbleProduct_To_EnumerableProductViewModel()
        {
            //ARRANGE
            var productController = new ProductController(SessionProducts());

            //ACT
            var view = productController.Index();

            //ASSERT
            Assert.IsType<AutoMapViewResult<IEnumerable<Product>, IEnumerable<ProductViewModel>>>(view);
        }

        private ISession SessionProducts()
        {
            var mockedSession = new Mock<ISession>();
            var testProducts = new List<Product>
            {
                new Product { Name = "TestProduct1", Price = 1 }, 
                new Product { Name = "TestProduct2", Price = 2 }, 
                new Product { Name = "TestProduct3", Price = 3 }
            }; 
            mockedSession.Setup(x => x.CreateCriteria<Product>().List<Product>()).Returns(testProducts);
            return mockedSession.Object;
        }
    }
}
