using System.IO;
using Newtonsoft.Json;

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
        return JsonConvert.DeserializeObject<AppSettings>(json) ?? new AppSettings();
    }

    public void SaveSettings()
    {
        var json = JsonConvert.SerializeObject(this, Formatting.Indented);
        File.WriteAllText(settingsFile, json);
    }


}
