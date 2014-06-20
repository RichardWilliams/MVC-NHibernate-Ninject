using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Core.NHibernate
{
    public class Sql2008Configurer : IDatabaseConfigurer
    {
        public IPersistenceConfigurer Configurer()
        {
            //return FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2008.ConnectionString(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\Michael\Documents\MVC-NHibernate-Ninject\MvcApplication1\App_Data\local.mdf;Integrated Security=True");
            return FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2008.ConnectionString(c => c.FromConnectionStringWithKey("DefaultConnection"));
        }
        public void BuildSchema(Configuration configuration)
        {
            new SchemaExport(configuration).Create(false, true);
        }
    }
}