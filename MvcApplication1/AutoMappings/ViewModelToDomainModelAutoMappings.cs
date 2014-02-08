using AutoMapper;
using DomainModel;
using MvcApplication1.Models;

namespace MvcApplication1.AutoMappings
{
    public class ViewModelToDomainModelAutoMappings
    {
        public void Configure()
        {
            Mapper.CreateMap<SaveProductViewModel, Product>();
        }
    }
}