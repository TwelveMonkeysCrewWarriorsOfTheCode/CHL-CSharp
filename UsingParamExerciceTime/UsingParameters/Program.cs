using System;
using System.Collections.Generic;

namespace UsingParameters
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Time> tempsTravFormate = new List<Time>();
			List<string> tempsTravail = new List<string>();
			for (int i = 0; i < 2; i++)
			{
				while (true)
				{
                    try
                    {
                        Console.Write($"Entrez un temps de travail {i + 1} : (HH:MM) ");
                        string heurelue = Console.ReadLine();
                        tempsTravail.Add(heurelue);
                        Time travaille = new Time(heurelue);
                        tempsTravFormate.Add(travaille);
                        if (tempsTravFormate[i].Hour == -1)
                        {
                            Console.WriteLine("Erreur de format");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Out of Range");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("La longueur du temps est fausse");
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine("Vous avez une erreur inconnue");
                        Console.WriteLine(exc.Message);
                    }
                    
				}
			}
            Console.Write("Entrez un multiplicateur : ");
            string multiplicateur = Console.ReadLine();
            int multi;
            if (!int.TryParse(multiplicateur, out multi)) multi = 1;
            Console.Write("Entrez un diviseur : ");
            string diviseur = Console.ReadLine();
            int divi;
            if (!int.TryParse(diviseur, out divi)) divi = 1;
            Time timeResult = Time.AddTime(tempsTravFormate[0], tempsTravFormate[1]);
			Console.WriteLine($"Add:{timeResult.ToString()}");
            timeResult = Time.SubTime(tempsTravFormate[0], tempsTravFormate[1]);
            Console.WriteLine($"Sub:{timeResult.ToString()}");
            timeResult = Time.MulTime(tempsTravFormate[0], multi);
            Console.WriteLine($"Mul:{timeResult.ToString()}");
            timeResult = Time.DivTime(tempsTravFormate[0], divi);
            Console.WriteLine($"Div:{timeResult.ToString()}");
        }
    }
}
/* exercices :
 * Poser la question à User
 * Entrez un temps de travail :
 * Quel jour avez-vous travaillé ?
 * 1. Lundi
 * 2. Mardi
 * 3. Mercredi
 * 4. Jeudi
 * 5. Vendredi
 * Avez-vous entré toutes vos prestations ? 
 * (Enter pour continuer / O pour afficher le rapport)
 * Add Time correct pour les minutes
 * Soustraire un time
 * Multiplier
 * Diviser 
 */