/**
 * Application de test de la fonction 'Polonaise'
 * author : Emds
 * date : 20/06/2020
-Si ce n'est pas déjà fait, récupérez le code du projet test ici.
-Ouvrez le sous Visual Studio et publiez-le sur GitHub (inutile de créer une seconde branche pour travailler).
-Dans le projet test, ajoutez la fonction que vous devez créer, en respectant les attentes du récit d'utilisateur (si vous ne l'avez pas encore récupéré, il est téléchargeable ici).
-Testez la fonction avec le jeu de données présent dans le récit d'utilisateur. Pensez à  utiliser le débogueur pour chercher l'origine des éventuels dysfonctionnements.
-Si tout fonctionne correctement, mettez à jour la version sur GitHub.
 */
using System;

namespace TestNotationPolonaise
{
    class Program
    {
        /// <summary>
        /// saisie d'une réponse d'un caractère parmi 2
        /// </summary>
        /// <param name="message">message à afficher</param>
        /// <param name="carac1">premier caractère possible</param>
        /// <param name="carac2">second caractère possible</param>
        /// <returns>caractère saisi</returns>
        static char saisie(string message, char carac1, char carac2)
        {
            char reponse;
            do
            {
                Console.WriteLine();
                Console.Write(message + " (" + carac1 + "/" + carac2 + ") ");
                reponse = Console.ReadKey().KeyChar;
            } while (reponse != carac1 && reponse != carac2);
            return reponse;
        }

        /// <summary>
        /// Saisie de formules en notation polonaise pour tester la fonction de calcul
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char reponse;
            // boucle sur la saisie de formules
            do
            {
                Console.WriteLine();
                Console.WriteLine("entrez une formule polonaise en séparant chaque partie par un espace = ");
                string laFormule = Console.ReadLine();
                // affichage du résultat
                Console.WriteLine("Résultat =  " + Polonaise(laFormule));
                reponse = saisie("Voulez-vous continuer ?", 'O', 'N');
            } while (reponse == 'O');
        }
    }
}
