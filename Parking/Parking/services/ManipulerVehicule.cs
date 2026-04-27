using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Parking.models;

namespace Parking.services
{
    internal class ManipulerVehicule
    {
        public static void ajouterVehicule()
        {
            int choix = 0;
            Console.WriteLine("\t\tQuel type de vehicule? voiture (1), ou utilitaire (2)");
            while (!int.TryParse(Console.ReadLine(), out choix))
            {
                Console.WriteLine("error");
            }

            if (choix == 1)
            {
                ajouterVoiture();
            }
            else { ajouterUtilitaire(); }
        }

        public static void ajouterVoiture()
        {
            Console.WriteLine("\t\timmat :\t\t");
            string immatriculation = Console.ReadLine();

            Console.WriteLine("\t\tSaisissez la marque :\t\t");
            string marque = Console.ReadLine();

            Console.WriteLine("\t\tSaisissez la couleur :\t\t");
            string couleur = Console.ReadLine();

            int nbPortes = 0;
            Console.WriteLine("\t\tSaisissez le nombre de portes :\t\t");
            while (!int.TryParse(Console.ReadLine(), out nbPortes))
            {
                Console.WriteLine("\t\terror");
            }

            Voiture Voiture = new Voiture(immatriculation, marque, couleur, nbPortes);

            Parking.parking.Add(Voiture);
        }

        public static void ajouterUtilitaire()
        {
            Console.WriteLine("\t\timmat :\t\t");
            string immatriculation = Console.ReadLine();

            Console.WriteLine("\t\tSaisissez la marque :\t\t");
            string marque = Console.ReadLine();

            Console.WriteLine("\t\tSaisissez la couleur :\t\t");
            string couleur = Console.ReadLine();


            int capaciteUtile = 0;
            Console.WriteLine("\t\tSaisissez la capaciteUtile:\t\t");
            while (!int.TryParse(Console.ReadLine(), out capaciteUtile))
            {
                Console.WriteLine("\t\terror");
            }

            Utilitaire utilitaire = new Utilitaire(immatriculation, marque, couleur, capaciteUtile);
            Parking.parking.Add(utilitaire);
        }

        public static void retirerVehicule(string immatriculation)
        {
            Console.WriteLine("\t\tQuel vehicule retirer?(immat)\n\t\t");
            string Recherche_immatriculation = Console.ReadLine();

            var index = Parking.parking.FindIndex(x => x.Immatriculation == Recherche_immatriculation);
            if (index >= 0)
            {
                Parking.parking.RemoveAt(index);
                Console.WriteLine("\t\tVous avais repris votre voiture placer en " + (index + 1) + " place");
            }
            else { Console.WriteLine("\t\tImmatriculation inconnue :'("); }
        }
    }
}
