namespace BuhtigIssueTrackerProgram.Core
{
    using System;

    using BuhtigIssueTrackerProgram;
    using BuhtigIssueTrackerProgram.Interfaces;
    using BuhtigIssueTrackerProgram.Utils;

    public class EndPointActionDispatcher
    {       
        public EndPointActionDispatcher()
            : this(new BuhtigIssueTracker())
        {
        }

        private EndPointActionDispatcher(IIssueTracker tracker)
        {
            this.Tracker = tracker;
        }

        private IIssueTracker Tracker { get; set; }

        public string DispatchAction(IEndpoint command)
        {
            switch (command.Command)
            {
                case "RegisterUser":
                    string username = command.ParametersDictionary["username"];
                    string password = command.ParametersDictionary["password"];
                    string confirmPassword = command.ParametersDictionary["confirmPassword"];
                    return this.Tracker.RegisterUser(username, password, confirmPassword);
                case "LoginUser":
                    username = command.ParametersDictionary["username"];
                    password = command.ParametersDictionary["password"];
                    return this.Tracker.LoginUser(username, password);
                case "LogoutUser":
                    return this.Tracker.LogoutUser();               
                case "CreateIssue":
                    string title = command.ParametersDictionary["title"];
                    string description = command.ParametersDictionary["description"];
                    string priorityString = command.ParametersDictionary["priority"];
                    IssuePriority priority = 
                        (IssuePriority)Enum.Parse(typeof(IssuePriority), priorityString, true);
                    string[] tags = command.ParametersDictionary["tags"].Split('|');
                    return this.Tracker.CreateIssue(title, description, priority, tags);
                case "RemoveIssue":
                    int issueId = int.Parse(command.ParametersDictionary["id"]);
                    return this.Tracker.RemoveIssue(issueId);
                case "AddComment":
                    issueId = int.Parse(command.ParametersDictionary["id"]);
                    string text = command.ParametersDictionary["text"];
                    return this.Tracker.AddComment(issueId, text);
                case "MyIssues":
                    return this.Tracker.GetMyIssues();
                case "MyComments":
                    return this.Tracker.GetMyComments();
                case "Search":
                    tags = command.ParametersDictionary["tags"].Split('|');
                    return this.Tracker.SearchForIssues(tags);
                default:
                    return string.Format("Invalid action: {0}", command.Command);
            }
        }
    }
}