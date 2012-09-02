using System.IO;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Core.NHibernate
{
    public class SQliteDatabaseConfigurer : IDatabaseConfigurer
    {
        private const string DBFileName = "MVCApp1.db";

        public IPersistenceConfigurer Configurer()
        {
            return SQLiteConfiguration.Standard.UsingFile(DBFileName);
        }

        public void BuildSchema(Configuration configuration)
        {
            if (File.Exists(DBFileName))
                File.Delete(DBFileName);

            new SchemaExport(configuration).Create(false, true);
        }
    }
}