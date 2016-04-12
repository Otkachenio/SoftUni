namespace Problem1.Logger.Layouts
{
    using System;
    using System.Text;

    using Interfaces;
    using Utils;

    public class XmlLayout : ILayout
    {
        public XmlLayout()
        {
        }

        public string MessageFormat(DateTime date, ReportLevels level, string message)
        {
            StringBuilder formatedMessage = new StringBuilder();

            formatedMessage.AppendLine("<log>");
            formatedMessage.AppendLine(string.Format("<date>{0}</date>", date));
            formatedMessage.AppendLine(string.Format("<level>{0}</level>", level.ToString()));
            formatedMessage.AppendLine(string.Format("<message>{0}</message>", message));
            formatedMessage.Append("</log>");

            return formatedMessage.ToString();
        }
    }
}
