using System.Text.Json;
using System.IO;

namespace NonogramOfficial.Models
{
    public class SettingsModel
    {
        private static readonly string settingsFile = "settings.json";

        public string FontFamily { get; set; } = "Arial"; // Default value
        public int DefaultGameSize { get; set; } = 0; // 0 - 3 modes

        public static AppSettings LoadSettings()
        {
            if (File.Exists(settingsFile))
            {
                string json = File.ReadAllText(settingsFile);
                return JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings();
            }
            return new AppSettings();
        }

        public void SaveSettings()
        {
            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(settingsFile, json);
        }
    }
}
