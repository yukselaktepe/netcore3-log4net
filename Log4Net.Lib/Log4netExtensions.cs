using log4net.Appender;
using Microsoft.Extensions.Logging;

namespace Log4Net.Lib
{
    public static class Log4netExtensions
    {
        public static ILoggerFactory AddLog4Net(this ILoggerFactory factory, IAppender[] appenders)
        {
            factory.AddProvider(new Log4NetProvider(appenders));
            return factory;
        }

        //public static ILoggerFactory AddLog4Net(this ILoggerFactory factory)
        //{
        //    factory.AddProvider(new Log4NetProvider("log4net.config"));
        //    return factory;
        //}
    }
}
