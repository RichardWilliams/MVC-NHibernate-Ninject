using Core.Mappings;
using FluentNHibernate.Cfg;
using NHibernate;

namespace Core.NHibernate
{
    public class NHibernateBuilder : INHibernateBuilder
    {
        private readonly IDatabaseConfigurer _databaseConfigurer;

        public NHibernateBuilder(IDatabaseConfigurer databaseConfigurer)
        {
            _databaseConfigurer = databaseConfigurer;
        }

        public ISessionFactory CreateSessionFactory()
        {
            return Fluently
                .Configure()
                .Database(_databaseConfigurer.Configurer)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProductMap>())
                .ExposeConfiguration(_databaseConfigurer.BuildSchema)
                .BuildSessionFactory();
        }
    }
}