using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonogramOfficial.Models
{
    public class User
    {
        /// Bevat de basisgegevens van een gebruiker
        public string Username { get; set; }
        public string Salt { get; set; }
        public string HashedPassword { get; set; }

    }
}
