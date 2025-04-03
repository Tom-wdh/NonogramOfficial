using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonogramOfficial.Models
{
    public class SettingsModel
    {
        private static readonly string settingsFile = "settings.json";

        public string FontFamily { get; set; } = "Arial"; // Standaard waarde
        public int DefaultGameSize { get; set; } = 0; //  0 - 3 modes


        public static AppSettings LoadSettings()
        {
            if (File.Exists(settingsFile))
            {
                string json = File.ReadAllText(settingsFile);
                return JsonConvert.DeserializeObject<AppSettings>(json) ?? new AppSettings();
            }
            return new AppSettings();
        }

        public void SaveSettings()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(settingsFile, json);
        }


    }
}
