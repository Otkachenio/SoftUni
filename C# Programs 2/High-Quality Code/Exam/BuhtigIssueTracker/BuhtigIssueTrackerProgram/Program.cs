namespace BuhtigIssueTrackerProgram
{
    using System.Globalization;
    using System.Threading;

    using BuhtigIssueTrackerProgram.Core;

    public class Program
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var engine = new Engine();
            engine.Run();
        }
    }
}