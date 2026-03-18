using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moncirque
{
    public class Personnel
    {
        private string Nom_personnel;
        private string Role_personnel;
        public Personnel(string nom, string role)
        {
            Nom_personnel = nom;
            Role_personnel = role;
        }
        public Personnel() { }
        public string getNomP()
        {
            return Nom_personnel;
        }
        public override string ToString()
        {
            return ($"{Nom_personnel}-{Role_personnel}");
        }

    }
}

