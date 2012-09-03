using System.Web.Mvc;
using MvcApplication1.Attributes;
using MvcApplication1.Filters;
using Ninject.Modules;
using Ninject.Web.Mvc.FilterBindingSyntax;

namespace MvcApplication1.App_Start
{
    internal class MVCApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.BindFilter<TransactionFilter>(FilterScope.Action, 0)
                .WhenActionMethodHas<TransactionAttribute>();
        }
    }
}