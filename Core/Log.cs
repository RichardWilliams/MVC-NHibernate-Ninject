namespace Core
{
    public interface ILog
    {
        string HelloWorld();
    }

    public class Log : ILog
    {
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}