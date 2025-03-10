using NonogramOfficial.Initializers;
using NonogramOfficial.Managers;

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

            var userManager = new UserManager();
            AppInitializer.InitializeUserData(userManager);

            Application.Run(new Hoofdpagina(userManager));
        }
    }
}