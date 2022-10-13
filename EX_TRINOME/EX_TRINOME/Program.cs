using System;

namespace EX_TRINOME
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            double a;
            double b;
            double c;
            string reponse;
            Console.WriteLine("Hello World!");

            //Récupération des données (lectures)
            Console.Write("Encodez la valeur du coéfficient x² : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Encodez la valeur du coéfficient x : ");
            b = double.Parse(Console.ReadLine());
            
            Console.Write("Encodez la valeur du indépendant : ");
            c = double.Parse(Console.ReadLine());

            if (a!=0)
            {
                //appel du morceau de programme de traintement
                SolTrinome(a, b, c,out reponse);
                Console.WriteLine(reponse);
            }
            else
            {
                //cas d'erreur : pas de traitement
                Console.WriteLine("Vous n'avez pas encodé un terme du second degré !");
            }
        }

        static void SolTrinome(double a, double b, double c, out string resultat)
        {
            //Déclaration des variables locales
            double delta;
            double x1;
            double x2;
            delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                resultat = "Il y a 2 solution:" + x1 + "et" + x2 + ".";
            }
            else
            {
                if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    resultat = "Il n'y a qu'une solution qui est :" + x1 + ".";
                }
                else
                {
                    resultat = "Il n'y a pas de solution réele";
                }
            }
        }
    }
}
