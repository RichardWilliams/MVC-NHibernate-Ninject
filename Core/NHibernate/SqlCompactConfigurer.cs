using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Core.NHibernate
{
    public class SqlCompactConfigurer : IDatabaseConfigurer
    {
        public IPersistenceConfigurer Configurer()
        {
            return MsSqlCeConfiguration.Standard.ConnectionString(@"Data Source=|DataDirectory|\MVCApp1.sdf");
        }

        public void BuildSchema(Configuration configuration)
        {
            new SchemaExport(configuration).Create(false, true);
        }
    }
}