using System;
using System.Security.Cryptography;
using System.Text;

namespace NonogramOfficial.Helpers
{
    /// Verantwoordelijk voor het genereren van salts en het hashen van wachtwoorden.
    public static class HashHelper
    {

        /// Maakt een unieke salt (Base64) met 16 random bytes.

        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        /// Maakt een SHA256-hash van het wachtwoord plus salt en geeft dit als Base64-string terug.
        public static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                // Combineer het wachtwoord en de salt
                string saltedPassword = password + salt;
                // Hash de bytes
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                // Zet de hash om in Base64
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
