namespace Problem1.Logger
{
    using Utils;
    using Appenders;
    using Layouts;

    public class LoggerMain
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.ReportLevel = ReportLevels.Error;

            var logger = new Logger(consoleAppender);

            logger.Info("Everything seems fine");
            logger.Warning("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");

            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warning("Warning - missing files.");
        }
    }
}