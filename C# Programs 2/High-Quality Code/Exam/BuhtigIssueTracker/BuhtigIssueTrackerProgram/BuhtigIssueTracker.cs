﻿namespace BuhtigIssueTrackerProgram
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    using BuhtigIssueTrackerProgram.Core;   
    using BuhtigIssueTrackerProgram.Interfaces;
    using BuhtigIssueTrackerProgram.Models;
    using BuhtigIssueTrackerProgram.Objects;    
    using BuhtigIssueTrackerProgram.Utils;
    
    public class BuhtigIssueTracker : IIssueTracker
    {
        public BuhtigIssueTracker(IBuhtigIssueTrackerData data)
        {
            this.Data = data as BuhtigIssueTrackerData;
        }

        public BuhtigIssueTracker()
            : this(new BuhtigIssueTrackerData())
        {
        }

        public BuhtigIssueTrackerData Data { get; set; }

        public string RegisterUser(string username, string password, string confirmPassword)
        {
            if (this.Data.CurrentUser != null)
            {
                return string.Format("There is already a logged in user");
            }

            if (password != confirmPassword)
            {
                return string.Format("The provided passwords do not match", username);
            }

            if (this.Data.UsersByUsername.ContainsKey(username))
            {
                return string.Format("A user with username {0} already exists", username);
            }

            var user = new User(username, password);
            this.Data.UsersByUsername.Add(username, user);
            return string.Format("User {0} registered successfully", username);
        }

        public string LoginUser(string username, string password)
        {
            if (this.Data.CurrentUser != null)
            {
                return string.Format("There is already a logged in user");
            }
                            
            if (!this.Data.UsersByUsername.ContainsKey(username))
            {
                return string.Format("A user with username {0} does not exist", username);
            }
                
            var user = this.Data.UsersByUsername[username];
            if (user.Password != PasswordHasher.HashPassword(password))
            {
                return string.Format("The password is invalid for user {0}", username);
            }

            this.Data.CurrentUser = user;

            return string.Format("User {0} logged in successfully", username);
        }

        public string LogoutUser()
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            string username = this.GetCurrentUsername();
            this.Data.CurrentUser = null;
            return string.Format("User {0} logged out successfully", username);
        }

        public string CreateIssue(
            string title, string description, IssuePriority priority, string[] tags)
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            var issue = new Issue(title, description, priority, tags.Distinct().ToList());           
            this.Data.AddIssue(issue);
            
            return string.Format("Issue {0} created successfully", issue.Id);
        }

        public string RemoveIssue(int issueId)
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            if (!this.Data.IssuesById.ContainsKey(issueId))
            {
                return string.Format("There is no issue with ID {0}", issueId);
            }

            var issue = this.Data.IssuesById[issueId];
            if (!this.Data.IssuesByUsername[this.Data.CurrentUser.Username].Contains(issue))
            {
                return string.Format(
                    "The issue with ID {0} does not belong to user {1}",
                    issueId, 
                    this.Data.CurrentUser.Username);
            }

            this.Data.RemoveIssue(issue);
            return string.Format("Issue {0} removed", issueId);
        }

        public string AddComment(int intValue, string stringValue)
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            if (!this.Data.IssuesById.ContainsKey(intValue))
            {
                return string.Format("There is no issue with ID {0}", intValue);
            }

            var issue = this.Data.IssuesById[intValue];
            var comment = new Comment(this.Data.CurrentUser, stringValue);
            issue.AddComment(comment);
            this.Data.CommentsByUser[this.Data.CurrentUser].Add(comment);
            return string.Format("Comment added successfully to issue {0}", issue.Id);
        }

        public string GetMyIssues()
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }                

            var issues = this.Data.IssuesByUsername[this.Data.CurrentUser.Username];
            var newIssues = issues;
            if (!newIssues.Any())
            {
                ////PERFORMANCE: Unneeded operations, string concatination in a loop
                
                return "No issues";
            }

            return string.Join(
                Environment.NewLine,
                newIssues
                    .OrderByDescending(x => x.Priority)
                    .ThenBy(x => x.Title));
        }

        public string GetMyComments()
        {
            if (this.Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            //// PERFORMANCE: Values where not retrieved from the corect dictionary
            var comments = this.Data.CommentsByUser[this.Data.CurrentUser];
            if (!comments.Any())
            {
                return "No comments";
            }

            var commnetsAsStrings = comments.Select(c => c.ToString());
            return string.Join(Environment.NewLine, commnetsAsStrings);
        }

        public string SearchForIssues(string[] tags)
        {
            if (tags.Length < 0)
            {
                return "There are no tags provided";
            }             

            var issues = new List<Issue>();
            foreach (var tag in tags)
            {
                issues.AddRange(this.Data.IssuesByTag[tag]);
            }
               
            if (!issues.Any())
            {
                return "There are no issues matching the tags provided";
            }
                
            var uniqueIssue = issues.Distinct();

            if (!uniqueIssue.Any())
            {
                return "No issues";
            }

            string result = string.Join(
                Environment.NewLine,
                uniqueIssue
                    .OrderByDescending(x => x.Priority)
                    .ThenBy(x => x.Title));

            return result;
        }

        private string GetCurrentUsername()
        {
            return this.Data.CurrentUser.Username;
        }
    }
}