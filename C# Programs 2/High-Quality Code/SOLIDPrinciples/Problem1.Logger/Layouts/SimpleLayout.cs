namespace Problem1.Logger.Layouts
{
    using System;

    using Interfaces;
    using Utils;

    public class SimpleLayout : ILayout
    {
        public SimpleLayout()
        {
        }   

        public string MessageFormat(DateTime date, ReportLevels level, string message)
        {
            string formatedMessage = string.Format("{0} - {1} - {2}",
                date, level.ToString(), message);

            return formatedMessage;
        }
    }
}