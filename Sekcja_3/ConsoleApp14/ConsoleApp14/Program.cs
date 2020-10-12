using System;
using System.IO;

namespace ConsoleApp14
{
    public class Program
    {
        public static ILogger GetLogger()
        {
            return new ConsoleLogger();
        }

        static void Main(string[] args)
        {
            //...

            var logger = GetLogger();

            SomeFunction(new ConsoleLogger());
            SomeFunction2(new ConsoleLogger());


            logger.LogMessage("wiadomosc");
            logger.LogMessage("wiadomosc KRYTYCZNA!!!!!", LogLevel.Critical);
        }

        private static void SomeFunction(ILogger logger)
        {

        }
        private static void SomeFunction2(IAnotherInterface anotherInterface)
        {

        }
    }

    public interface ILogger
    {
        //all methods and properties in interface are public
        LogLevel LogLevel { get; set; }
        void LogMessage(string message, LogLevel logLevel = LogLevel.Debug);
    }

    public interface IAnotherInterface
    {

    }

    public class ConsoleLogger : ILogger, IAnotherInterface
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Verbose;

        public void LogMessage(string message, LogLevel logLevel = LogLevel.Debug)
        {
            if (LogLevel > LogLevel)
                return;

            Console.WriteLine(message);
        }
    }

    public class FileLogger : ILogger
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Critical;
        public void LogMessage(string message, LogLevel logLevel = LogLevel.Debug)
        {
            if (LogLevel > LogLevel)
                return;

            File.WriteAllText("logs.txt", message);
        }
    }

    public enum LogLevel
    {
        Verbose,
        Debug,
        Critical
    }
}
