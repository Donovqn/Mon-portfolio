using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.models
{
    class Utilitaire : Vehicule
    {
        private int capaciteUtile;

        public int CapaciteUtile { get => capaciteUtile; set => capaciteUtile = value; }

        public Utilitaire(string immatriculation, string marque, string couleur, int capaciteUtile) : base(immatriculation, marque, couleur)
        {
            this.capaciteUtile = capaciteUtile;
        }



        public override string ToString()
        {
            return $"vous avez déposer votre voiture utilitaire : {Immatriculation}";
        }
    }
}
