using System;
using System.Collections.Generic;
using System.Text;

namespace _5TTI_Matrice_Evrard
{
    public struct Traitement
    {
        /// <summary>
        /// nbrLigne et nbrColonne doivent être entier et non nul
        /// 
        /// Obtenir une matrice avec des valeur aléatoires
        /// </summary>
        /// <param name="nbrLigne">nombre de ligne dans la matrice</param>
        /// <param name="nbrColonne">nombre de colonne dans la matrice</param>
        /// <param name="matrice">la matrice contenant toute les valeurs</param>
        public void GenererAleatoireMatrice (int nbrLigne, int nbrColonne, out int[,] matrice)
        {
            matrice = new int[nbrLigne, nbrColonne];
            Random valeur = new Random();
            for (int compteurLigne = 0; compteurLigne <= nbrLigne - 1; compteurLigne++)
            {
                for (int compteurColonne = 0; compteurColonne <= nbrColonne - 1; compteurColonne++)
                {
                    matrice[compteurLigne, compteurColonne] = valeur.Next(0, 21);
                }
            }
        }
        /// <summary>
        /// Les matrices doivent être crées au préalable
        /// 
        /// Concaténer une matrice en chaine de caractère
        /// </summary>
        /// <param name="matrice">matrice d’entier</param>
        /// <param name="chaine">chaine de caractère résultant d’une concaténation d’une matrice</param>
        public void ConcaténationMatrice (int[,] matrice, out string chaine)
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
        /// <summary>
        /// Les matrices doivent être créés au préalable
        /// 
        /// Vérifier si on peut additionner 2 matrices et le faire si c’est le cas
        /// </summary>
        /// <param name="matriceUn">Matrice d’entier</param>
        /// <param name="matriceDeux">Matrice d’entier</param>
        /// <param name="additionnable">Vérifie que les 2 matrices peuvent être additionnés</param>
        /// <param name="resultat">Matrice contenant l’addition des autres matrices</param>
        public void AdditionMatrice (int[,] matriceUn, int[,] matriceDeux, out bool additionnable, out int[,] resultat)
        {
            resultat = new int[matriceUn.GetLength(0), matriceUn.GetLength(1)];

            if (matriceUn.GetLength(0) == matriceDeux.GetLength(0) && matriceUn.GetLength(1) == matriceDeux.GetLength(1))
            {
                additionnable = true;
                for (int compteurLigne = 0; compteurLigne <= matriceUn.GetLength(0) - 1; compteurLigne++)
                {
                    for (int compteurColonne = 0; compteurColonne <= matriceUn.GetLength(1) - 1; compteurColonne++)
                    {
                        resultat[compteurLigne, compteurColonne] = 0;
                        resultat[compteurLigne, compteurColonne] = matriceUn[compteurLigne, compteurColonne] + matriceDeux[compteurLigne, compteurColonne];
                    }
                }
            }
            else
            {
                additionnable = false;
            }
        }
        /// <summary>
        /// Les matrices doivent être crées au préalable
        /// 
        /// Verifier si on peut multiplier les 2 matrices et le faire si c’est le cas
        /// </summary>
        /// <param name="matriceUn">Matrice d’entier</param>
        /// <param name="matriceDeux">Matrice d’entier</param>
        /// <param name="multipliable">Vérifie que les 2 matrices peuvent être multipliés</param>
        /// <param name="resultat">Matrice contenant la multiplication des autres matrices</param>
        public void MultiplicationMatrice (int[,] matriceUn, int[,] matriceDeux, out bool multipliable, out int[,] resultat)
        {
            resultat = new int[matriceUn.GetLength(0), matriceDeux.GetLength(1)];

            if (matriceUn.GetLength(1) == matriceDeux.GetLength(0))
            {
                multipliable = true;
                for (int compteurLigne = 0; compteurLigne <= matriceUn.GetLength(0) - 1; compteurLigne++)
                {
                    for (int compteurColonne = 0; compteurColonne <= matriceDeux.GetLength(1) - 1; compteurColonne++)
                    {
                        resultat[compteurLigne, compteurColonne] = 0;
                        for (int compteurLigneColonne = 0; compteurLigneColonne <= matriceUn.GetLength(1) - 1; compteurLigneColonne++)
                        {
                            resultat[compteurLigne, compteurColonne] = resultat[compteurLigne, compteurColonne] + matriceUn[compteurLigne, compteurLigneColonne] * matriceDeux[compteurLigneColonne, compteurColonne];
                        }
                    }
                }
            }
            else
            {
                multipliable = false;
            }
        }
        /// <summary>
        /// La question doit être ecrité à l'avance
        /// 
        /// Verifier si la valeur rentrée par l'utilisateur est un entier
        /// </summary>
        /// <param name="question">Question posé par la console</param>
        /// <param name="n">Renvoie la réponse de l'utilisateur si il s'agit d'un nombre sinon renvoie un message d'erreur</param>
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
    }
}
