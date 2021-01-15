using System;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string firstName;
            string name;
            int age;
            int born;
            // On demande des informations auprès de l'utilisateur
            Console.WriteLine("Quel est vôtre Nom ?");
            firstName = Console.ReadLine();

            Console.WriteLine("Quel est vôtre Prénom ?");
            name = Console.ReadLine();

            Console.WriteLine("Quel est vôtre année de naissance ?");
            born = Convert.ToInt32(Console.ReadLine());
            
            // Je calcule son age, grâce à l'année qu'il m'a donné
            age = 2021 - born;

            // Je crée une fiche de renseignement
            Console.WriteLine(" Fiche de renseignement");
            Console.WriteLine(" * Nom :" + firstName);
            Console.WriteLine(" * Prénom :" + name);
            Console.WriteLine(" * Age :" + age);
                    

        }
    }
}
