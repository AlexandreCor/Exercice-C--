using System;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration de 2 variables typées
            int firstNumber;
            int secondNumber;
            
            // Fonction qui permet d'écrire dans la console
            Console.WriteLine("entrer la valeur du premier nombre X= ");
            // On lit le résultat de l'utilisateur, on le convertit, est on stock dans la variable
            firstNumber = int.Parse(Console.ReadLine()); // Readline et Parse sont des fonctions

            Console.WriteLine("entrer la valeur du second nombre Y= ");
            secondNumber = int.Parse(Console.ReadLine());

            // On crée une variable de type entier dans laquelle on stock le calcul firstNumber +33
            double x = firstNumber + 33;
            // On crée une variable de type entier dans laquelle on stock l'incrémentation de secondNumber
            double y = secondNumber++;
            // On crée une variable de type double et on y stock le résultat
            double result = x / y;

            Console.WriteLine("Le résultat est " + result);
            


            
        }
    }
}
