using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using NonogramOfficial.Controllers;

namespace NonogramOfficial.Tests
{
    public class IntegrationTests
    {
        private const string TestSettingsFile = "testSettings.json";
        private const int MaxRetryAttempts = 3;
        private const int DelayBetweenRetries = 1000; // in milliseconds

        public IntegrationTests()
        {
            EnsureUsersDirectoryExists();
        }

        private void EnsureUsersDirectoryExists()
        {
            if (!Directory.Exists("Users"))
            {
                Directory.CreateDirectory("Users");
            }
        }

        [Fact]
        public async Task RegisterUserAndSaveSettings_ShouldWork()
        {
            // Arrange
            var userController = new UserController();
            var settingsController = new SettingsController(TestSettingsFile);

            // Zorg dat we met een schone lei beginnen
            DeleteDirectoryWithRetry("Users");
            EnsureUsersDirectoryExists();
            DeleteFileWithRetry(TestSettingsFile);

            // Act
            // 1. Gebruiker registreren
            var regResult = await userController.RegisterUserAsync("testUser", "testPassword");
            EnsureUsersDirectoryExists(); // Ensure directory exists after registration

            // Check if the user file exists
            var userFilePath = Path.Combine("Users", "testUser", "testUser.json");
            Assert.True(File.Exists(userFilePath), "User file should exist after registration");

            // 2. Gebruiker inloggen
            var loginResult = await userController.LoginUserAsync("testUser", "testPassword");

            // 3. Instelling aanpassen en opslaan
            settingsController.Settings.FontFamily = "Georgia";
            settingsController.SaveSettings();
            // 4. Instelling herladen
            settingsController.LoadSettings();

            // Assert
            Assert.True(regResult, "Registreren zou moeten slagen");
            Assert.True(loginResult, "Inloggen zou moeten slagen");
            Assert.Equal("Georgia", settingsController.Settings.FontFamily);

            // Cleanup
            await userController.DeleteUserAsync("testUser");
            DeleteFileWithRetry(TestSettingsFile);
            DeleteDirectoryWithRetry("Users");
        }

        [Fact]
        public async Task RegisterLoginAndDeleteUser_ShouldWork()
        {
            // Arrange
            var userController = new UserController();

            // Zorg dat we met een schone lei beginnen
            DeleteDirectoryWithRetry("Users");
            EnsureUsersDirectoryExists();

            // Act
            // 1. Gebruiker registreren
            var regResult = await userController.RegisterUserAsync("testUserToDelete", "testPassword");
            EnsureUsersDirectoryExists(); // Ensure directory exists after registration

            // Check if the user file exists
            var userFilePath = Path.Combine("Users", "testUserToDelete", "testUserToDelete.json");
            Assert.True(File.Exists(userFilePath), "User file should exist after registration");

            // 2. Gebruiker inloggen
            var loginResult = await userController.LoginUserAsync("testUserToDelete", "testPassword");
            // 3. Gebruiker verwijderen
            var deleteResult = await userController.DeleteUserAsync("testUserToDelete");

            // Assert
            Assert.True(regResult, "Registreren zou moeten slagen");
            Assert.True(loginResult, "Inloggen zou moeten slagen");
            Assert.True(deleteResult, "Verwijderen zou moeten slagen");

            // Cleanup
            DeleteDirectoryWithRetry("Users");
        }

        private void DeleteFileWithRetry(string filePath)
        {
            for (int attempt = 0; attempt < MaxRetryAttempts; attempt++)
            {
                try
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                    break;
                }
                catch (UnauthorizedAccessException)
                {
                    if (attempt == MaxRetryAttempts - 1)
                    {
                        throw;
                    }
                    Task.Delay(DelayBetweenRetries).Wait();
                }
            }
        }

        private void DeleteDirectoryWithRetry(string directoryPath)
        {
            for (int attempt = 0; attempt < MaxRetryAttempts; attempt++)
            {
                try
                {
                    if (Directory.Exists(directoryPath))
                    {
                        Directory.Delete(directoryPath, true);
                    }
                    break;
                }
                catch (UnauthorizedAccessException)
                {
                    if (attempt == MaxRetryAttempts - 1)
                    {
                        throw;
                    }
                    Task.Delay(DelayBetweenRetries).Wait();
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"IOException: {ex.Message}");
                    if (attempt == MaxRetryAttempts - 1)
                    {
                        throw;
                    }
                    Task.Delay(DelayBetweenRetries).Wait();
                }
            }
        }
    }
}
