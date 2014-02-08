using Ninject.Extensions.Logging;

namespace MvcApplication1.Common
{
    public interface IHaveALogger
    {
        ILogger Logger();
    }
}