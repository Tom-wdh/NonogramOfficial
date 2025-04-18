﻿using System.Text.Json;
using NonogramOfficial.Models;
using System.IO;

namespace NonogramOfficial.Controllers
{
    public class SettingsController
    {
        private static readonly object fileLock = new object();
        private readonly string _filePath;
        public SettingsModel Settings { get; private set; }

        public SettingsController(string filePath = "settings.json")
        {
            _filePath = filePath;
            LoadSettings();
        }

        public void SaveSettings()
        {
            lock (fileLock)
            {
                var json = JsonSerializer.Serialize(Settings, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);
            }
        }

        public void LoadSettings()
        {
            lock (fileLock)
            {
                if (File.Exists(_filePath))
                {
                    var json = File.ReadAllText(_filePath);
                    Settings = JsonSerializer.Deserialize<SettingsModel>(json) ?? new SettingsModel();
                }
                else
                {
                    Settings = new SettingsModel();
                    SaveSettings();
                }
            }
        }
    }
}
