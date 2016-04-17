namespace IssueTracker.Tests
{
    using System;

    using BuhtigIssueTrackerProgram;
    using BuhtigIssueTrackerProgram.Utils;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class CreateIssueTests
    {
        private string username = "username";
        private string password = "password";
        private string title = "validTitle";
        private string description = "Valid descrtiption";
        private IssuePriority priority = IssuePriority.High;
        private string[] tags = new[] { "test", "tag" };
        private int issueId = 1;

        public BuhtigIssueTracker RegisterUser(string username, string password)
        {
            var tracker = new BuhtigIssueTracker();
            tracker.RegisterUser(username, password, password);

            return tracker;
        }

        [TestMethod]
        public void Test_CreatingNewIssue_ShouldCreateTheIssue()
        {
            var tracker = RegisterUser(username, password);
            tracker.LoginUser(username, password);
            string expected = string.Format("Issue {0} created successfully", issueId);

            string viewResult = tracker.CreateIssue(title, description, priority, tags);
            
            Assert.AreEqual(expected, viewResult);
        }

        [TestMethod]
        public void Test_CreatingNewIssueWithoutLoggedIn_ShouldReturnErrorMessage()
        {
            var tracker = RegisterUser(username, password);
            string expected = string.Format("There is no currently logged in user");

            string viewResult = tracker.CreateIssue(title, description, priority, tags);

            Assert.AreEqual(expected, viewResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Title should be at least 3 chars long.")]
        public void Test_CreatingNewIssueWithOneCharTitle_ShouldReturnErrorMessage()
        {
            string test = "t";
            var tracker = RegisterUser(username, password);
            tracker.LoginUser(username, password);

            tracker.CreateIssue(test, description, priority, tags);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Description should be at least 5 chars long.")]
        public void Test_CreatingNewIssueWithOneCharDesc_ShouldReturnErrorMessage()
        {
            string test = "t";
            var tracker = RegisterUser(username, password);
            tracker.LoginUser(username, password);

            string viewResult = tracker.CreateIssue(title, test, priority, tags);
        }
    }
}