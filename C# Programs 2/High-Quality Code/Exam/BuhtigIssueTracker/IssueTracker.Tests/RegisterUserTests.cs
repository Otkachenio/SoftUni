namespace IssueTracker.Tests
{
    using System.Linq;
    
    using BuhtigIssueTrackerProgram;
    using BuhtigIssueTrackerProgram.Utils;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RegisterUserTests
    {
        private string username = "validUsername";
        private string password = "validPassword";

        public void RegisterUser(string username, string password)
        {
            var tracker = new BuhtigIssueTracker();
            tracker.RegisterUser(username, password, password);
        }

        [TestMethod]
        public void Test_RegisterUser_ShouldRegisterTheUser()
        {
            
            string expected = string.Format("User {0} registered successfully", username);

            var tracker = new BuhtigIssueTracker();
            string viewResult = tracker.RegisterUser(username, password, password);

            Assert.AreEqual(expected, viewResult);
            Assert.AreEqual(1, tracker.Data.UsersByUsername.Count);
        }

        [TestMethod]
        public void Test_UsernameAndPassword_ShouldReturnTheCorrectUsernameAndPassword()
        {
            var tracker = new BuhtigIssueTracker();
            string viewResult = tracker.RegisterUser(username, password, password);

            var user = tracker.Data.UsersByUsername.First().Value;

            Assert.AreEqual(username, user.Username);
            Assert.AreEqual(PasswordHasher.HashPassword(password), user.Password);
        }

        [TestMethod]
        public void Test_RegisterWithAlredyLoggedInUser_ShouldReturnErrorMessage()
        {
            string expected = "There is already a logged in user";
            var tracker = new BuhtigIssueTracker();
            tracker.RegisterUser(username, password, password);
            tracker.LoginUser(username, password);

            string viewResult = tracker.RegisterUser(username, password, password);

            Assert.AreEqual(expected, viewResult);
        }

        [TestMethod]
        public void Test_WithDifferentPasswords_ShouldReturnErrorMessage()
        {
            string invalidPassword = "invalidPassword";
            string expected = "The provided passwords do not match";

            var tracker = new BuhtigIssueTracker();
            string viewResult = tracker.RegisterUser(username, password, invalidPassword);

            Assert.AreEqual(expected, viewResult);
        }

        [TestMethod]
        public void Test_RegisterUserWithRepeatingUsername_ShouldReturnErrorMessage()
        {
            string expected = string.Format("A user with username {0} already exists", username);
            var tracker = new BuhtigIssueTracker();
            tracker.RegisterUser(username, password, password);

            string viewResult = tracker.RegisterUser(username, password, password);

            Assert.AreEqual(expected, viewResult);
        }
    }
}