namespace Problem1.Logger.Interfaces
{
    using Utils;

    public interface IAppender
    {
        void AppendMessage(ReportLevels level, string message);
    }
}