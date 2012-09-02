using NHibernate;

namespace Core.NHibernate
{
    public interface INHibernateBuilder
    {
        ISessionFactory CreateSessionFactory();
    }
}