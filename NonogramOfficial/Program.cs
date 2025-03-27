using NonogramOfficial.Initializers;
using NonogramOfficial.Controllers;
using NonogramOfficial.Helpers;

namespace NonogramOfficial
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var userManager = new UserController();
            AppInitializer.InitializeUserData(userManager);

            AppSettings settings = AppSettings.LoadSettings();

            var hoofdForm = new Hoofdpagina(userManager);
            FontHelper.ApplyGlobalFont(hoofdForm, settings.FontFamily);

            Application.Run(hoofdForm);
        }
    }
}