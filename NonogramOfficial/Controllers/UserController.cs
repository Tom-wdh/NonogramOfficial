using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Newtonsoft.Json;
using NonogramOfficial.Helpers;
using NonogramOfficial.Models;
using User = NonogramOfficial.Models.User;

namespace NonogramOfficial.Controllers 
{
    
    public class UserController : User
    {
        private readonly string dataDirectory = "Users";
        public User? LoggedInUser { get; private set; }


        public UserController()
        {
            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }
        }

        // Geeft de namen van alle JSON-bestanden in de "Users"-directory terug.
        public string[] CheckExistingJsonFiles()
        {
            if (Directory.Exists(dataDirectory))
            {
                return Directory.GetFiles(dataDirectory, "*.json")
                               .Select(Path.GetFileName)
                               .ToArray();
            }
            return Array.Empty<string>();
        }

        // Registreer een nieuwe gebruiker asynchroon
        public async Task<bool> RegisterUserAsync(string username, string password)
        {
            string filePath = Path.Combine(dataDirectory, username + ".json");
            if (File.Exists(filePath))
            {
                // Als het bestand al bestaat, dan is deze user al aangemaakt
                return false;
            }

            // Salt genereren
            string salt = HashHelper.GenerateSalt();

            // Wachtwoord met salt hashen
            string hashedPassword = HashHelper.HashPassword(password, salt);

            // Gebruiker-Object
            var newUser = new NonogramOfficial.Models.User
            {
                Username = username,
                Salt = salt,
                HashedPassword = hashedPassword
            };

            // Schrijf naar JSON
            string json = JsonConvert.SerializeObject(newUser, Formatting.Indented);
            await File.WriteAllTextAsync(filePath, json);

            return true;
        }

        // LoginUserAsync
        public async Task<bool> LoginUserAsync(string username, string password)
        {
            string filePath = Path.Combine(dataDirectory, username + ".json");

            if (!File.Exists(filePath))
            {
                return false;
            }

            string json = await File.ReadAllTextAsync(filePath);
            var user = JsonConvert.DeserializeObject<User>(json);

            string hashedInput = HashHelper.HashPassword(password, user.Salt);

            if (hashedInput == user.HashedPassword)
            {
                LoggedInUser = user;  // Sla de ingelogde gebruiker op
                return true;
            }
            else
            {
                LoggedInUser = null;
                return false;
            }
        }



        // Profielbeheer - UPDATE user data //
        public async Task<bool> UpdateUserAsync(string oldUsername, string newUsername, string? newPassword)
        {
            string oldFilePath = Path.Combine(dataDirectory, oldUsername + ".json");
            if (!File.Exists(oldFilePath))
            {
                return false; // Bestaat niet
            }

            // 1) Lees huidige gegevens
            string json = await File.ReadAllTextAsync(oldFilePath);
            var user = JsonConvert.DeserializeObject<User>(json);

            // 2) Verwerk wijzigingen
            if (!string.IsNullOrEmpty(newPassword))
            {
                string newSalt = HashHelper.GenerateSalt();
                string newHashedPassword = HashHelper.HashPassword(newPassword, newSalt);
                user.Salt = newSalt;
                user.HashedPassword = newHashedPassword;
            }
            user.Username = newUsername;

            // 3) Hernoem bestand als de username verandert
            string newFilePath = Path.Combine(dataDirectory, newUsername + ".json");
            if (!oldUsername.Equals(newUsername, StringComparison.OrdinalIgnoreCase))
            {
                File.Delete(oldFilePath);
            }

            // 4) Schrijf naar JSON
            string updatedJson = JsonConvert.SerializeObject(user, Formatting.Indented);
            await File.WriteAllTextAsync(newFilePath, updatedJson);

            // 5) Als het de ingelogde gebruiker is, update LoggedInUser
            if (LoggedInUser != null &&
                LoggedInUser.Username.Equals(oldUsername, StringComparison.OrdinalIgnoreCase))
            {
                LoggedInUser = user;
            }
            return true;
        }

        // DELETE USER
        public bool DeleteUser(string username)
        {
            string filePath = Path.Combine(dataDirectory, username + ".json");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                if (LoggedInUser != null &&
                    LoggedInUser.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    LoggedInUser = null;
                }
                return true;
            }
            return false;
        }




    }



}
