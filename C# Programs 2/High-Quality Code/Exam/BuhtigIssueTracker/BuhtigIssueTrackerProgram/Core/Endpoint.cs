namespace BuhtigIssueTrackerProgram.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;

    using BuhtigIssueTrackerProgram.Interfaces;

    public class Endpoint : IEndpoint
    {
        public Endpoint(string inputString)
        {
            int questionIndex = inputString.IndexOf('?');
            bool containsQuestionMark = questionIndex >= 0 ? true : false;

            if (containsQuestionMark)
            {
                this.CreateWithEnpointParameters(inputString, questionIndex);
            }
            else
            {
                this.Command = inputString;
            }
        }

        public string Command { get; set; }

        public IDictionary<string, string> ParametersDictionary { get; set; }

        private void CreateWithEnpointParameters(string inputString, int questionIndex)
        {
            this.Command = inputString.Substring(0, questionIndex);
            var parameterKeyValuePairs = inputString.Substring(questionIndex + 1)
                .Split('&');
            var keysAndValues = parameterKeyValuePairs
                .Select(userData => userData.Split('=')
                    .Select(data => WebUtility.UrlDecode(data))
                    .ToArray());

            var parameters = new Dictionary<string, string>();
            foreach (var keyAndValue in keysAndValues)
            {
                parameters.Add(keyAndValue[0], keyAndValue[1]);
            }

            this.ParametersDictionary = parameters;
        }
    }
}