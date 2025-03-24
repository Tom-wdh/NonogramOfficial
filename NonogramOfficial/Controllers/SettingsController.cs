using Newtonsoft.Json;
using NonogramOfficial.Models;
using System.IO;

namespace NonogramOfficial.Controllers
{
    public class SettingsController
    {
        private readonly string _filePath = "settings.json";
        public SettingsModel Settings { get; private set; }

        public SettingsController()
        {
            LoadSettings();
        }

        public void SaveSettings()
        {
            var json = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public void LoadSettings()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                Settings = JsonConvert.DeserializeObject<SettingsModel>(json) ?? new SettingsModel();
            }
            else
            {
                Settings = new SettingsModel();
                SaveSettings();
            }
        }
    }
}
