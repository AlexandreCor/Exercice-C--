using System;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 20;
            int secondNumber = 36;
            int thirdNumber = 76;
            int sum1 = firstNumber + secondNumber;
            int sum2 = sum1 * thirdNumber;

            Console.WriteLine("Le premier nombre est " + firstNumber);
            Console.WriteLine("Le second nombre est " + secondNumber);
            Console.WriteLine("Le troisème nombre est " + thirdNumber);
            Console.WriteLine("Le résultat du premier calcul est " + sum1);
            Console.WriteLine("Le résultat du second calcul est " + sum2);
        }
    }
}
