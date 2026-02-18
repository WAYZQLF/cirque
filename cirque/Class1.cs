using System.Security.Cryptography.X509Certificates;

namespace cirque
{
    public class Accessoire
    {
        private string Nom;
        private string Couleur;
        private double Volume;
        private int Ratelier;
        private int Camion;

        public Accessoire(string nom, string couleur, double volume, int ratelier, int camion)
        {
            this.Nom = nom;
            this.Couleur = couleur;
            this.Volume = volume;
            this.Ratelier = ratelier;
            this.Camion = camion;
        }
        public override string ToString()
        {
            return ($"{Nom} {Couleur} Volume {Volume} Camion {Camion}");
        }

    }
    public class Personnel
    {
        private string Nom_personnel;
        private string Role_personnel;
        public Personnel(string nom, string role)
        {
            Nom_personnel = nom;
            Role_personnel = role;
        }
        public override string ToString()
        {
            return ($"{Nom_personnel}-{Role_personnel}");
        }

    }
} 
