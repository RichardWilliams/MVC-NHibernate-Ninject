using System.Web.Mvc;
using MvcApplication1.AutoMappings;

namespace MvcApplication1.Extensions
{
    public static class ControllerExtensions
    {
        public static ActionResult AutoMapView<TDomainModel, TViewModel>(this Controller controller, ViewResult viewResult, TDomainModel domainModel)
        {
            return new AutoMapViewResult<TDomainModel, TViewModel>(viewResult, domainModel);
        }
    }
}