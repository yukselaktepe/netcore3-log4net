using log4net.Appender;
using log4net.Layout;


namespace Log4Net.Lib.Appenders
{
    public static class Configuration
    {
        public static IAppender CreateConsoleAppender()
        {
            ConsoleAppender appender = new ConsoleAppender() { Name = "ConsoleAppender" };
            PatternLayout layout = new PatternLayout() { ConversionPattern = "%date [%thread] %-5level %logger - %message%newline" };
            layout.ActivateOptions();
            appender.Layout = layout;
            appender.ActivateOptions();
            return appender;
        }

        public static IAppender CreateTraceAppender()
        {
            TraceAppender appender = new TraceAppender() { Name = "TraceAppender" };
            PatternLayout layout = new PatternLayout() { ConversionPattern = "%date [%thread] %-5level %logger - %message%newline" };
            layout.ActivateOptions();
            appender.Layout = layout;
            appender.ActivateOptions();
            return appender;
        }

        public static IAppender CreateRollingFileAppender(string logFilePath)
        {
            RollingFileAppender appender = new RollingFileAppender()
            {
                Name = "RollingFileAppender",
                File = logFilePath,
                AppendToFile = true,
                RollingStyle = RollingFileAppender.RollingMode.Composite,
                DatePattern = "yyyyMMdd",
                StaticLogFileName = true,
                MaxSizeRollBackups = 20,
                MaximumFileSize = "5MB"
            };

            PatternLayout layout = new PatternLayout()
            {
                Header = "[Header] ",
                Footer = "[Footer] ",
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };

            layout.ActivateOptions();
            appender.Layout = layout;
            appender.ActivateOptions();
            return appender;
        }

    }
}
