namespace DateTimeTest
{
    using System;

    public interface IDateTimeProvider
    {
        DateTime DateTimeNow { get; }
    }
}