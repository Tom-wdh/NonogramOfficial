using NonogramOfficial.Initializers;
using NonogramOfficial.Controllers;

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

            Application.Run(new Hoofdpagina(userManager));
        }
    }
}