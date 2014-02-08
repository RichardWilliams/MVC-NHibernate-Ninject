using System;
using System.Web.Mvc;
using MvcApplication1.Common;

namespace MvcApplication1.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class LoggingFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllerWithLogging = filterContext.Controller as IHaveALogger;
            if (controllerWithLogging == null) return;
            controllerWithLogging.Logger().Debug("RouteData: {0}", filterContext.RouteData );
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }
    }
}