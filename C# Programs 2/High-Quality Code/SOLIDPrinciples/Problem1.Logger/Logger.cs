namespace Problem1.Logger
{
    using System;

    using Interfaces;
    using Utils;

    public class Logger : ILogger
    {
        private IAppender appender;
        private IAppender secondAppender;

        public Logger(IAppender appender)
        {
            this.appender = appender;
        }

        public Logger(IAppender appender, IAppender secondAppender) : this(appender)
        {
            this.secondAppender = secondAppender;
        }

        public void Info(string message)
        {
            Append(ReportLevels.Info, message);
        }

        public void Warning(string message)
        {
            Append(ReportLevels.Warning, message);
        }

        public void Error(string message)
        {
            Append(ReportLevels.Error, message);
        }     
        
        public void Fatal(string message)
        {
            Append(ReportLevels.Fatal, message);
        }

        public void Critical(string message)
        {
            Append(ReportLevels.Critical, message);
        }

        public void Append(ReportLevels level, string message)
        {
            appender.AppendMessage(level, message);

            if (secondAppender != null)
            {
                secondAppender.AppendMessage(level, message);
            }
        }
    }
}