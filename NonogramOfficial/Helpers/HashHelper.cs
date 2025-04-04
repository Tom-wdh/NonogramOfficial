using System;
using System.Security.Cryptography;
using System.Text;

namespace NonogramOfficial.Helpers
{
    /// Verantwoordelijk voor het genereren van salts en het hashen van wachtwoorden.
    public static class HashHelper
    {

        public static string GenerateSalt()
        {
            byte[] salt = new byte[16];
            RandomNumberGenerator.Fill(salt);
            return Convert.ToBase64String(salt);
        }

        public static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] saltedPassword = Encoding.UTF8.GetBytes(password + salt);
                byte[] hash = sha256.ComputeHash(saltedPassword);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
