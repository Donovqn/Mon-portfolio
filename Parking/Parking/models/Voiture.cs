using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.models
{
    class Voiture : Vehicule
    {

        private int nombrePortes;

        public int NombrePortes { get => nombrePortes; set => nombrePortes = value; }

        public Voiture(string immatriculation, string marque, string couleur, int nombrePorte) : base(immatriculation, marque, couleur)
        {
            nombrePortes = nombrePortes;
        }



        public override string ToString()
        {
            return $"vous avez déposer votre voiture immatriculé : {Immatriculation}";
        }
    }


}
