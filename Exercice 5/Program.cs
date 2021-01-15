using System;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variations
            string firstname;
            string name;

            // Question pour l'utilisateur
            Console.WriteLine("Quel est vôtre nom ? ");
            name = Console.ReadLine();
            Console.WriteLine("Quel est vôtre prénom ? ");
            firstname = Console.ReadLine();

            // Date
            DateTime dat = DateTime.Now;

            Console.WriteLine("Bonjour " + name + " " + firstname + ", nous sommes le " + dat + ", comment allez-vous ?");
           




        }
    }
}
