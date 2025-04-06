using System.Text.Json;
using NonogramOfficial.Controllers;
using NonogramOfficial.Models;
using System.IO;
using System.Reflection;
using Xunit;

namespace NonogramOfficial.Tests
{
    public class SettingsControllerTests
    {
        private const string TestFilePath = "test_settings.json";

        [Fact]
        public void LoadSettings_FileExists_LoadsSettings()
        {
            // Arrange
            var settings = new SettingsModel { FontFamily = "Georgia", DefaultGameSize = 10 };
            var settingsJson = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(TestFilePath, settingsJson);

            var settingsController = new SettingsController(TestFilePath);

            // Act
            settingsController.LoadSettings();

            // Assert
            Assert.NotNull(settingsController.Settings);
            Assert.Equal("Georgia", settingsController.Settings.FontFamily);
            Assert.Equal(10, settingsController.Settings.DefaultGameSize);

            // Cleanup
            File.Delete(TestFilePath);
        }

        [Fact]
        public void LoadSettings_FileDoesNotExist_CreatesDefaultSettings()
        {
            // Arrange
            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }

            var settingsController = new SettingsController(TestFilePath);

            // Act
            settingsController.LoadSettings();
            settingsController.Settings.FontFamily = "Georgia";

            // Assert
            Assert.NotNull(settingsController.Settings);
            Assert.Equal("Georgia", settingsController.Settings.FontFamily);
            Assert.Equal(0, settingsController.Settings.DefaultGameSize);
            Assert.True(File.Exists(TestFilePath));

            // Cleanup
            File.Delete(TestFilePath);
        }

        [Fact]
        public void SaveSettings_WritesSettingsToFile()
        {
            // Arrange
            var settingsController = new SettingsController(TestFilePath);
            var settings = new SettingsModel { FontFamily = "Georgia", DefaultGameSize = 10 };

            // Use reflection to set the private set accessor
            var settingsProperty = typeof(SettingsController).GetProperty("Settings", BindingFlags.Public | BindingFlags.Instance);
            settingsProperty.SetValue(settingsController, settings);

            // Act
            settingsController.SaveSettings();

            // Assert
            var expectedJson = JsonSerializer.Serialize(settingsController.Settings, new JsonSerializerOptions { WriteIndented = true });
            var actualJson = File.ReadAllText(TestFilePath);
            Assert.Equal(expectedJson, actualJson);

            // Cleanup
            File.Delete(TestFilePath);
        }
    }
}
