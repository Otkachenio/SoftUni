namespace BuhtigIssueTrackerProgram.Interfaces
{
    using System.Collections.Generic;

    public interface IEndpoint
    {
        string Command { get; }

        IDictionary<string, string> ParametersDictionary { get; }
    }
}