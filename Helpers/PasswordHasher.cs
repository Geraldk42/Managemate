using BCrypt.Net;

namespace Managemate.Helpers
{
    public static class PasswordHasher
    {
        // Method to hash a password
        public static string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Method to verify a password
        public static bool Verify(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
