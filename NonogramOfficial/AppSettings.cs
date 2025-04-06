using System.IO;
using System.Text.Json;

public class AppSettings
{
    public string FontFamily { get; set; } = "Arial"; // Standaard
    public int DefaultGameSize { get; set; }

    private static readonly string settingsFile = "settings.json";

    public static AppSettings LoadSettings()
    {
        if (!File.Exists(settingsFile))
            return new AppSettings(); // Als er geen bestand is, maak nieuwe aan

        var json = File.ReadAllText(settingsFile);
        return JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings();
    }

    public void SaveSettings()
    {
        var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(settingsFile, json);
    }
}
