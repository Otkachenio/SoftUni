namespace Problem1.Logger.Interfaces
{
    using System;

    using Utils;

    public interface ILayout
    {
        string MessageFormat(DateTime date, ReportLevels level, string message);
    }
}