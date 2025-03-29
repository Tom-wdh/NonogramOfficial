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
        private readonly string dataDirectory = "Users"; // Hoofdmap voor alle gebruikers
        public User? LoggedInUser { get; private set; }


        public UserController()
        {
            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }
        }

        // Helper-methodes om de padnamen op te bouwen
        private string GetUserDirectory(string username)
        {
            return Path.Combine(dataDirectory, username);
        }

        private string GetUserFilePath(string username)
        {
            return Path.Combine(GetUserDirectory(username), username + ".json");
        }

        // Geeft de namen van alle JSON-bestanden in de "Users"-directory terug.
        public string[] CheckExistingJsonFiles()
        {
            if (Directory.Exists(dataDirectory))
            {
                var jsonFiles = Directory.GetDirectories(dataDirectory)
                    .Select(dir => Directory.GetFiles(dir, "*.json").FirstOrDefault())
                    .Where(file => !string.IsNullOrEmpty(file))
                    .Select(file => Path.GetFileName(file))
                    .ToArray();
                return jsonFiles;
            }
            return Array.Empty<string>();
        }

        // Registreer een nieuwe gebruiker asynchroon
        public async Task<bool> RegisterUserAsync(string username, string password)
        {
            string userDir = GetUserDirectory(username);
            string filePath = GetUserFilePath(username);
            string salt = HashHelper.GenerateSalt();
            string hashedPassword = HashHelper.HashPassword(password, salt);

            if (!Directory.Exists(userDir))
            {
                Directory.CreateDirectory(userDir);
            }

            if (File.Exists(filePath))
            {
                return false;
            }



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
            string filePath = GetUserFilePath(username);
            string json = await File.ReadAllTextAsync(filePath);
            var user = JsonConvert.DeserializeObject<User>(json);
            string hashedInput = HashHelper.HashPassword(password, user.Salt);

            if (!File.Exists(filePath))
            {
                return false;
            }

            
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
            string oldFilePath = GetUserFilePath(oldUsername);
            string json = await File.ReadAllTextAsync(oldFilePath);
            var user = JsonConvert.DeserializeObject<User>(json);
            string newSalt = HashHelper.GenerateSalt();
            string newHashedPassword = HashHelper.HashPassword(newPassword, newSalt);


            if (!File.Exists(oldFilePath))
            {
                return false; // Bestaat niet
            }

            if (!string.IsNullOrEmpty(newPassword))
            {
                user.Salt = newSalt;
                user.HashedPassword = newHashedPassword;
            }
            user.Username = newUsername;

            // Als de username verandert, werk dan de mapstructuur bij
            if (!oldUsername.Equals(newUsername, StringComparison.OrdinalIgnoreCase))
            {
                string oldUserDir = GetUserDirectory(oldUsername);
                string newUserDir = GetUserDirectory(newUsername);
                string newFilePath = GetUserFilePath(newUsername);
                string updatedJson = JsonConvert.SerializeObject(user, Formatting.Indented);

                // Maak nieuwe map aan indien nodig
                if (!Directory.Exists(newUserDir))
                {
                    Directory.CreateDirectory(newUserDir);
                }

                // Schrijf geüpdatete data naar de nieuwe file
                await File.WriteAllTextAsync(newFilePath, updatedJson);

                // Verwijder het oude bestand
                File.Delete(oldFilePath);
                // Indien gewenst: verwijder de oude map als deze leeg is
                if (Directory.GetFiles(oldUserDir).Length == 0 && Directory.GetDirectories(oldUserDir).Length == 0)
                {
                    Directory.Delete(oldUserDir);
                }
            }
            else
            {
                // Als de username niet is veranderd, update dan gewoon het bestand
                string updatedJson = JsonConvert.SerializeObject(user, Formatting.Indented);
                await File.WriteAllTextAsync(oldFilePath, updatedJson);
            }

            // Update LoggedInUser indien nodig
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
            string userDir = GetUserDirectory(username);
            string filePath = GetUserFilePath(username);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                // Verwijder de gebruikersmap indien deze leeg is
                if (Directory.Exists(userDir) &&
                    Directory.GetFiles(userDir).Length == 0 &&
                    Directory.GetDirectories(userDir).Length == 0)
                {
                    Directory.Delete(userDir);
                }
                if (LoggedInUser != null &&
                    LoggedInUser.Username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    LoggedInUser = null;
                }
                return true;
            }
            return false;
        }

        public void LogOutUser()
        {
            LoggedInUser = null;
        }

    }
}
