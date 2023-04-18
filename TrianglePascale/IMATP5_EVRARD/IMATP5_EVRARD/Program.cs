using System;

namespace IMATP5_EVRARD
{
    class Program
    {
        static void Main(string[] args)
        {
            Methode outils = new Methode();
            int tailleTriangle;
            bool pasZero = false;
            int[,] triangle;
            string conca;
            string afficher;
            string chaine;
            bool ouiNon = false;
            string recommencer;
            bool restart = false;

            do
            {
                do
                {
                    outils.LireEntier("Que voulez vous comme taille pour votre matrice ?", out tailleTriangle);
                    if (tailleTriangle == 0)
                    {
                        Console.WriteLine("Veuillez rentrer une valeur non nul");
                        pasZero = true;
                    }
                } while (pasZero == true);
                outils.RenvoieTriangle(tailleTriangle, out triangle);
                outils.ConcaténationMatrice(triangle, out conca);
                Console.WriteLine("Voici votre triangle de Pascale: " + conca);
                do
                {
                    Console.WriteLine("Voulez vous qu'on vous affiche le développement ? (Oui/Non)");
                    afficher = Console.ReadLine();
                    if (afficher == "Oui")
                    {
                        outils.ConstructionChaine(tailleTriangle, triangle, out chaine);
                        Console.WriteLine("Voici le developpement : " + chaine);
                        ouiNon = true;
                    }
                    else if (afficher == "Non")
                    {
                        ouiNon = true;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez repondre uniquement par Oui ou Non");
                        ouiNon = false;
                    }
                } while (ouiNon == false);
                do
                {
                    Console.WriteLine("Voulez-vous recommencer ? Oui/Non");
                    recommencer = Console.ReadLine();
                    if (recommencer == "Oui")
                    {
                        restart = true;
                        ouiNon = true;
                    }
                    else if (recommencer == "Non")
                    {
                        restart = false;
                        ouiNon = true;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez repondre uniquement par Oui ou Non");
                        ouiNon = false;
                    }
                } while (ouiNon == false);

            } while (restart == true);
        }
    }
}
