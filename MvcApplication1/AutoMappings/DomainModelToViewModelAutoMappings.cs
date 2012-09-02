using AutoMapper;
using DomainModel;
using MvcApplication1.Models;

namespace MvcApplication1.AutoMappings
{
    public class DomainModelToViewModelAutoMappings
    {
        public void Configure()
        {
            Mapper.CreateMap<Product, ProductViewModel>();
        }
    }
}