using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.models
{
    class Vehicule
    {


        private string immatriculation;
        private string marque;
        private string couleur;


        public string Immatriculation { get => immatriculation; set => immatriculation = value; }
        public string Marque { get => marque; set => marque = value; }
        public string Couleur { get => couleur; set => couleur = value; }

        public Vehicule(string immatriculation, string marque, string couleur)
        {
            this.immatriculation = immatriculation;
            this.marque = marque;
            this.couleur = couleur;
        }


    }
}
