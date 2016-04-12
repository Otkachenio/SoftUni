namespace Problem1.Logger.Appenders
{
    using System;

    using Interfaces;
    using Utils;

    public class ConsoleAppender : Appender, IAppender
    {
         public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void AppendMessage(ReportLevels level, string message)
        {
            if (this.ReportLevel <= level)
            {
                Console.WriteLine(Layout.MessageFormat(DateTime.Now, level, message));
            }
        }
    }
}