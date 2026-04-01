using System.Security.Cryptography.X509Certificates;

namespace Moncirque
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
        public Accessoire() { }
        public string getNom()
        {
            return Nom;
        }
        public override string ToString()
        {
            return ($"{Nom} ({Couleur}) Volume {Volume} Camion {Camion}");
        }

    }
} 
