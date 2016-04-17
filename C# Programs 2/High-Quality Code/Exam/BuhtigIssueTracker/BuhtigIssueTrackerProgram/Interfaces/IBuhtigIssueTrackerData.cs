﻿namespace BuhtigIssueTrackerProgram.Interfaces
{
    using System.Collections.Generic;

    using BuhtigIssueTrackerProgram.Models;
    using BuhtigIssueTrackerProgram.Objects;
    using Wintellect.PowerCollections;

    public interface IBuhtigIssueTrackerData
    {
        User CurrentUser { get; set; }

        IDictionary<string, User> UsersByUsername { get; }

        OrderedDictionary<int, Issue> IssuesById { get; }

        MultiDictionary<string, Issue> IssuesByUsername { get; }

        MultiDictionary<string, Issue> IssuesByTag { get; }

        MultiDictionary<User, Comment> CommentsByUser { get; }

        int AddIssue(Issue p);

        void RemoveIssue(Issue p);
    }
}