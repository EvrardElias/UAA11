using System;
using System.Collections.Generic;
using System.Text;

namespace IMATP5_EVRARD
{
    public struct Methode
    {
        public void RenvoieTriangle(int tailleTriangle, out int[,] triangle)
        {
            triangle = new int[tailleTriangle, tailleTriangle];
            triangle[0, 0] = 1;
            for (int nbrLigne = 1; nbrLigne <= tailleTriangle - 1; nbrLigne++)
            {
                for (int nbrColonne = 0; nbrColonne <= tailleTriangle - 1; nbrColonne++)
                {
                    triangle[nbrLigne, nbrColonne] = 0;
                    if (nbrColonne == 1)
                    {
                        triangle[nbrLigne, nbrColonne] = 1;
                    }
                    else
                    {
                        triangle[nbrLigne, nbrColonne] = triangle[nbrLigne - 1, nbrColonne - 1] + triangle[nbrLigne - 1, nbrColonne - 1];
                    }
                }
            }
        }

        public void ConstructionChaine(int tailleTriangle, int[,] triangle, out string chaine)
        {
            chaine = "";
            for (int nbrColonne = 0; nbrColonne <= tailleTriangle - 1; nbrColonne++)
            {
                chaine = chaine + triangle[tailleTriangle - 1, nbrColonne] + "a^" + (tailleTriangle - nbrColonne) + "b^" + nbrColonne + "+";
            }
        }

        public void LireEntier(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine("Attention! Vous ne devez taper qu'un nombre entier !");
                nUser = Console.ReadLine();
            }
        }

        public void ConcaténationMatrice(int[,] matrice, out string chaine)
        {
            chaine = "";
            for (int compteurLigne = 0; compteurLigne <= matrice.GetLength(0) - 1; compteurLigne++)
            {
                for (int compteurColonne = 0; compteurColonne <= matrice.GetLength(1) - 1; compteurColonne++)
                {
                    chaine = chaine + matrice[compteurLigne, compteurColonne] + " ";
                }
                chaine = chaine + "\n";
            }
        }
    }
}
