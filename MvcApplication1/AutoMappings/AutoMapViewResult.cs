using System.Web.Mvc;
using AutoMapper;

namespace MvcApplication1.AutoMappings
{
    public class AutoMapViewResult<TDomainModel, TViewModel> : ActionResult
    {
        private readonly ViewResult _viewResult;
        private readonly TDomainModel _domainModel;

        public AutoMapViewResult(ViewResult viewResult, TDomainModel domainModel)
        {
            _viewResult = viewResult;
            _domainModel = domainModel;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var viewModel = Mapper.Map<TDomainModel, TViewModel>(_domainModel);

            _viewResult.ViewData.Model = viewModel;
            _viewResult.ExecuteResult(context);
        }
    }
}