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

namespace NonogramOfficial.Managers
{
    
    public class UserManager
    {
        private readonly string dataDirectory = "Users";


        public UserManager()
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
            // Bepaal het JSON-bestand op basis van de gebruikersnaam
            string filePath = Path.Combine(dataDirectory, username + ".json");

            // Bestaat het bestand niet? Gebruiker bestaat niet
            if (!File.Exists(filePath))
            {
                return false;
            }

            // Lees het JSON-bestand uit
            string json = await File.ReadAllTextAsync(filePath);
            var user = JsonConvert.DeserializeObject<User>(json);

            // Hash het ingevoerde wachtwoord met de opgeslagen salt
            string hashedInput = HashHelper.HashPassword(password, user.Salt);

            // Vergelijk de hash met de opgeslagen hash
            return hashedInput == user.HashedPassword;
        }


    }



}
