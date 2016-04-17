namespace BuhtigIssueTrackerProgram.Utils
{
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            string hashedPassword = string.Join(
                string.Empty,
                SHA1.Create()
                .ComputeHash(Encoding.Default.GetBytes(password))
                .Select(x => x.ToString()));

            return hashedPassword;
        }
    }
}