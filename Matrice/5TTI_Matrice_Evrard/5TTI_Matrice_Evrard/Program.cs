using System;

namespace _5TTI_Matrice_Evrard
{
    class Program
    {
        static void Main(string[] args)
        {
            Traitement outils = new Traitement();
            string choix; ///Reprend le choix dans le menu
            int[,] matriceUn; ///Matrice d'entier n°1 pour les calcul et utilisé pour la génération aléatoire 
            int nbrLigne; ///Nombre de ligne dans la matrice
            int nbrColonne;///Nombre de colonne dans la matrice
            string chaine;///Chaine de caractère avec la valeur des matrices afin de pouvoir l'afficher
            int[,] matriceDeux; ///Matrice d'entier n°1 pour les calcul
            bool additionnable; ///Contient la valeur True/False et en fonction de sa valeur permet d'afficher le resultat ou le message d'erreur
            int[,] resultat; ///Matrice reprenant la somme ou le produit des calcule effectués
            bool multipliable; ///Contient la valeur True/False et en fonction de sa valeur permet d'afficher le resultat ou le message d'erreur
            string newTraitement; ///Contient la valeur de si l'utilisateur veut recommencer avec un nouveau traitement
            string recommencer; ///Si la valeur pour les dimensions vaut 0 alors recommencer 

            do
            {

                do
                {

                    Console.WriteLine("Quelle opération voulez vous faire ? \nTapez 1 : Générer une matrice aléatoire. \nTapez 2 : Additionner 2 matrices. \nTapez 3 : Multiplier 2 matrices.");
                    choix = Console.ReadLine();

                    if (choix == "1") ///Génération aléatoire
                    {
                        do
                        {
                            outils.LireEntier("Combien de ligne voulez-vous dans la matrice ?", out nbrLigne);
                            if (nbrLigne == 0)
                            {
                                Console.WriteLine("Le nombre de ligne ne peut pas valoir 0");
                                recommencer = "Oui";
                            }
                            else
                            {
                                recommencer = "Non";
                            }
                        } while (recommencer == "Oui");

                        do
                        {
                            outils.LireEntier("Combien de colonne voulez-vous dans la matrice ?", out nbrColonne);
                            if (nbrColonne == 0)
                            {
                                Console.WriteLine("Le nombre de colonne ne peut pas valoir 0");
                                recommencer = "Oui";
                            }
                            else
                            {
                                recommencer = "Non";
                            }
                            
                        } while (recommencer == "Oui");
                        outils.GenererAleatoireMatrice(nbrLigne, nbrColonne, out matriceUn);
                        outils.ConcaténationMatrice(matriceUn, out chaine);
                        Console.WriteLine("Voici votre matrice : \n" + chaine);
                    }
                    else if (choix == "2") ///L'addition
                    {
                        do
                        {
                            outils.LireEntier("Combien de ligne voulez-vous dans la matrice n°1 ?", out nbrLigne);
                            if (nbrLigne == 0)
                            {
                                Console.WriteLine("Le nombre de ligne ne peut pas valoir 0");
                                recommencer = "Oui";
                            }
                            else
                            {
                                recommencer = "Non";
                            }
                            
                        } while (recommencer == "Oui");

                        do
                        {
                            outils.LireEntier("Combien de colonne voulez-vous dans la matrice n°1 ?", out nbrColonne);
                            if (nbrColonne == 0)
                            {
                                Console.WriteLine("Le nombre de colonne ne peut pas valoir 0");
                                recommencer = "Oui";
                            }
                            else
                            {
                                recommencer = "Non";
                            }

                        } while (recommencer == "Oui");

                        outils.GenererAleatoireMatrice(nbrLigne, nbrColonne, out matriceUn);

                        do
                        {
                            outils.LireEntier("Combien de ligne voulez-vous dans la matrice n°2 ?", out nbrLigne);
                            if (nbrLigne == 0)
                            {
                                Console.WriteLine("Le nombre de ligne ne peut pas valoir 0");
                                recommencer = "Oui";
                            }
                            else
                            {
                                recommencer = "Non";
                            }

                        } while (recommencer == "Oui");

                        do
                        {
                            outils.LireEntier("Combien de colonne voulez-vous dans la matrice n°2 ?", out nbrColonne);
                            if (nbrColonne == 0)
                            {
                                Console.WriteLine("Le nombre de colonne ne peut pas valoir 0");
                                recommencer = "Oui";
                            }
                            else
                            {
                                recommencer = "Non";
                            }

                        } while (recommencer == "Oui");
                        outils.GenererAleatoireMatrice(nbrLigne, nbrColonne, out matriceDeux);
                        outils.ConcaténationMatrice(matriceUn, out chaine);
                        Console.WriteLine("Voici votre première matrice : \n" + chaine);
                        outils.ConcaténationMatrice(matriceDeux, out chaine);
                        Console.WriteLine("Voici votre deuxième matrice : \n" + chaine);
                        outils.AdditionMatrice(matriceUn, matriceDeux, out additionnable, out resultat);
                        if (additionnable == false)
                        {
                            Console.WriteLine("Vos matrice ne peuvent pas être additionnés");
                        }
                        else
                        {
                            outils.ConcaténationMatrice(resultat, out chaine);
                            Console.WriteLine("Voici la somme de vos matrices : \n" + chaine);
                        }

                    }
                    else if (choix == "3") ///La multiplication
                    {
                        do
                        {
                            outils.LireEntier("Combien de ligne voulez-vous dans la matrice n°1 ?", out nbrLigne);
                            if (nbrLigne == 0)
                            {
                                Console.WriteLine("Le nombre de ligne ne peut pas valoir 0");
                                recommencer = "Oui";
                            }
                            else
                            {
                                recommencer = "Non";
                            }

                        } while (recommencer == "Oui");

                        do
                        {
                            outils.LireEntier("Combien de colonne voulez-vous dans la matrice n°1 ?", out nbrColonne);
                            if (nbrColonne == 0)
                            {
                                Console.WriteLine("Le nombre de colonne ne peut pas valoir 0");
                                recommencer = "Oui";
                            }
                            else
                            {
                                recommencer = "Non";
                            }

                        } while (recommencer == "Oui");

                        outils.GenererAleatoireMatrice(nbrLigne, nbrColonne, out matriceUn);

                        do
                        {
                            outils.LireEntier("Combien de ligne voulez-vous dans la matrice n°2 ?", out nbrLigne);
                            if (nbrLigne == 0)
                            {
                                Console.WriteLine("Le nombre de ligne ne peut pas valoir 0");
                                recommencer = "Oui";
                            }
                            else
                            {
                                recommencer = "Non";
                            }

                        } while (recommencer == "Oui");

                        do
                        {
                            outils.LireEntier("Combien de colonne voulez-vous dans la matrice n°2 ?", out nbrColonne);
                            if (nbrColonne == 0)
                            {
                                Console.WriteLine("Le nombre de colonne ne peut pas valoir 0");
                                recommencer = "Oui";
                            }
                            else
                            {
                                recommencer = "Non";
                            }

                        } while (recommencer == "Oui");
                        outils.GenererAleatoireMatrice(nbrLigne, nbrColonne, out matriceDeux);
                        outils.ConcaténationMatrice(matriceUn, out chaine);
                        Console.WriteLine("Voici votre première matrice : \n" + chaine);
                        outils.ConcaténationMatrice(matriceDeux, out chaine);
                        Console.WriteLine("Voici votre deuxième matrice : \n" + chaine);
                        outils.MultiplicationMatrice(matriceUn, matriceDeux, out multipliable, out resultat);
                        if (multipliable == false)
                        {
                            Console.WriteLine("Vos matrice ne peuvent pas être multipliés");
                        }
                        else
                        {
                            outils.ConcaténationMatrice(resultat, out chaine);
                            Console.WriteLine("Voici le produit de vos matrices : \n" + chaine);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Veuillez rentrer uniquement un chiffre entre 1 et 3 s'il vous plait");
                        choix = "Non";
                    }

                } while (choix == "Non");

                do
                {
                    Console.WriteLine("Voulez-vous faire un nouveau traitement ? Oui/Non");
                    newTraitement = Console.ReadLine();
                    if (newTraitement != "Oui" || newTraitement != "Non")
                    {
                        Console.WriteLine("Veuillez rentrer uniquement Oui ou Non");
                        recommencer = "Oui";
                    }
                    else
                    {
                        recommencer = "Non";
                    }
                } while (recommencer == "Oui");

            } while (newTraitement == "Oui");
        }
    }
}
