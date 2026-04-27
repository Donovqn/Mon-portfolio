using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.services
{
    internal class Affichage
    {
        public static void choix()
        {




            int choix;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t1 : Ajouter un véhicule");
                Console.WriteLine("\t\t2 : Ajouter plusieur véhicules");
                Console.WriteLine("\t\t3 : Retirer véhicule");
                Console.WriteLine("\t\t4 : Afficher parking");
                Console.WriteLine("\t\t5 : Ajouts véhicules test");
                Console.WriteLine("\t\t0 : Sortir\n");

                choix = lireInt("\t\tQue voullez vous faire?", "0 pour sortir");

                switch (choix)
                {
                    case 1:
                        ManipulerVehicule.ajouterVehicule();
                        break;

                    case 2:
                        Console.WriteLine("\t\tCombien de véhicule?\t\t");
                        if (int.TryParse(Console.ReadLine(), out int i) && i > 0) ;
                        else { Console.WriteLine("\t\tError\t\t"); }
                        for (int j = 0; j < i; j++) { ManipulerVehicule.ajouterVehicule(); }
                        break;

                    case 3:
                        ManipulerVehicule.retirerVehicule("\t\timmatriculation\t\t");
                        break;

                    case 4:
                        Parking.checkParking();
                        break;

                    case 5:
                        AjouterVoituresTest.ajouterVoituresTest();
                        Parking.checkParking();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\t\terreur");
                        break;


                }
            } while (choix != 0);




            static int lireInt(string message1, string message2)
            {
                int x = 0;
                Console.WriteLine(message1);
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(message2);
                }
                return x;
            }
        }
    }
}
