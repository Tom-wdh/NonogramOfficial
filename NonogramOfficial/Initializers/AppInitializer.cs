using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NonogramOfficial.Managers;

namespace NonogramOfficial.Initializers
{
    public static class AppInitializer
    {
        public static void InitializeUserData(UserManager userManager)
        {
            // Controleer of er al gebruikersbestand(en) zijn
            var existingFiles = userManager.CheckExistingJsonFiles();
            if (existingFiles.Length == 0)
            {
                // Maak een standaard admin-account aan als er nog geen gebruikers zijn
                userManager.RegisterUserAsync("admin", "admin123").GetAwaiter().GetResult();
            }
        }
    }
}
