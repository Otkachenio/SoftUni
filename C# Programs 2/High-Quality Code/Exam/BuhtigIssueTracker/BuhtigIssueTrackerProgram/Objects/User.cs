namespace BuhtigIssueTrackerProgram.Objects
{
    using BuhtigIssueTrackerProgram.Utils;

    public class User
    {
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = PasswordHasher.HashPassword(password);
        }

        public string Username { get; set; }

        public string Password { get; set; }
    }  
}