using DomainModel;
using FluentNHibernate.Mapping;

namespace Core.Mappings
{
    public class StoreMap : ClassMap<Store>
    {
        public StoreMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Employees)
                .Inverse()
                .Cascade.All();
            HasManyToMany(x => x.Products)
                .Cascade.All()
                .Table("StoreProducts");
        }
    }
}