/** 
 * Exercice 20
 * author : Nael PETIT
 * date : 21/10/2021 
 */
using System;

namespace exogit
{
    class Program
    {
        static void Main(string[] args)
        {
            string ville = "placeholder";
            int habitants = 0;
            char trigger = 'O';
            bool correct=false,correct1=false;

            //Début programme
            while (trigger != 'n')
            {
                //Demande si une saisie est à faire
                correct = false;
                while (correct == false)
                {
                    try
                    {
                        Console.WriteLine("Avez vous une saisie à faire? O/n");
                        trigger = char.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Saisie invalide");
                    }
                }
                //Début saisie si saisie à faire
                if (trigger!='n')
                {
                    Console.WriteLine("Quelle est votre ville ?");
                    ville = Console.ReadLine();
                    Console.WriteLine("Combien de personnes habitent cette ville ?");
                    correct1 = false;
                    while (correct1 == false)
                    {
                        try
                        {
                            habitants = int.Parse(Console.ReadLine());
                            correct1 = true;
                        }
                        catch
                        {
                            Console.Write("Une erreur est intervenue, veuillez resaisir le nombre d'habitants:");
                        }
                    }
                    Console.WriteLine(ville + " possède " + habitants + " habitants");
                }
                //Si pas de saisie à faire: sortir de la boucle
                else
                {
                    trigger = 'n';
                }
            }

        }
    }
}

