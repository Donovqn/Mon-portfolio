using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.models;

namespace Parking.services
{
    internal class Parking
    {
        public static List<Vehicule> parking = new List<Vehicule>();

        public static void checkParking()
        {
            foreach (var vehicule in parking)
            {
                Console.WriteLine($"\t\tImmatriculation : {vehicule.Immatriculation}, Marque : {vehicule.Marque}");
            }
        }
    }
}
