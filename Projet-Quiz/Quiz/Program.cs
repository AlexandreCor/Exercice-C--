using System;
using System.Collections.Generic;

namespace Quiz
{
    public class QuizHelp
    {

        public void FonQuiz(int i)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("1. Qu'est ce que le C# ?");
                    Console.WriteLine("1 - Une marque d'écharpe");
                    Console.WriteLine("2 - Un Framework");
                    Console.WriteLine("3 - Un language de programmation");
                    Console.WriteLine("4 - une plateforme de jeux vidéos");
                    break;
                case 2:
                    Console.WriteLine("2. Qu'elle est la syntaxe correcte pour afficher \" Hello World \" en C# ?");
                    Console.WriteLine("1 - coucou = \" Hello World \"");
                    Console.WriteLine("2 - printf(\"Hello, World!\");");
                    Console.WriteLine("3 - echo 'Hello, World!';");
                    Console.WriteLine("4 - Console.WriteLine(\"Hello World!\");");
                    break;
                case 3:
                    Console.WriteLine("3. Quelle est la commande permettant d'écrire des commentaires en C# ?");
                    Console.WriteLine("1 - //");
                    Console.WriteLine("2 - \\\\");
                    Console.WriteLine("3 - #/");
                    Console.WriteLine("4 - \"\"");
                    break;
                case 4:
                    Console.WriteLine("4. Quel type de variable est utilisé pour créer / stocker du texte ?");
                    Console.WriteLine("1 - sting");
                    Console.WriteLine("2 - string");
                    Console.WriteLine("3 - int");
                    Console.WriteLine("4 - stock");
                    break;
                case 5:
                    Console.WriteLine("5. Quel opérateur peut être utilisé pour comparer deux valeurs ?");
                    Console.WriteLine("1 - <>");
                    Console.WriteLine("2 - +<");
                    Console.WriteLine("3 - ==");
                    Console.WriteLine("4 - [ == ]");
                    break;
                case 6:
                    Console.WriteLine("6. Pour déclarer un tableau en C#, définissez le type de variable avec :");
                    Console.WriteLine("1 - ()");
                    Console.WriteLine("2 - {}");
                    Console.WriteLine("3 - []");
                    Console.WriteLine("4 - <>");
                    break;
                case 7:
                    Console.WriteLine("7. Quel type de variable est utilisé pour créer / stocker un chiffre ?");
                    Console.WriteLine("1 - double");
                    Console.WriteLine("2 - string");
                    Console.WriteLine("3 - int");
                    Console.WriteLine("4 - bool");
                    break;
                case 8:
                    Console.WriteLine("8. Quel est la syntax correcte pour réaliser une boucle de 10 itérations ?");
                    Console.WriteLine("1 - for (int i = 1; i <= 10; i++)");
                    Console.WriteLine("2 - for (int i = 0; i > 10; i++)");
                    Console.WriteLine("3 - for (int i = 1; i < 10; i++)");
                    Console.WriteLine("4 - for (int i = 0; i <= 10; i++)");
                    break;
                case 9:
                    Console.WriteLine("9. Comment convertir une entrée console en variable de type entier ?");
                    Console.WriteLine("1 - Convert.Int(Console.ReadLine());");
                    Console.WriteLine("2 - Convert.ToInt32(Console.ReadLine());");
                    Console.WriteLine("3 - Convert.ToInt(Console.ReadLine());");
                    Console.WriteLine("4 - Convert.ToInt24(Console.ReadLine());");
                    break;
                case 10:
                    Console.WriteLine("10. En quelle année le C# à-t-il été crée ?");
                    Console.WriteLine("1 - 1999");
                    Console.WriteLine("2 - 2001");
                    Console.WriteLine("3 - 2003");
                    Console.WriteLine("4 - 2005");
                    break;
                default:
                    Console.WriteLine("!!!Debug - erreur d'entrée fonction!!!");
                    break;
            }
        }
    }
   

    class Program
    {
        static void Main(string[] args)
        {
               string[,] goodAnswers = new string[10, 3] {
               { "3", "1. Qu'est ce que le C# ?", "3 - Un language de programmation" },
               { "4", "2. Qu'elle est la syntaxe correcte pour afficher \" Hello World \" en C# ?", "4 - Console.WriteLine(\"Hello World!\");" },
               { "1", "3. Quelle est la commande permettant d'écrire des commentaires en C# ?", "1 - //" },
               { "2", "4. Quel type de variable est utilisé pour créer / stocker du texte ?", "2 - \\\\" },
               { "3", "5. Quel opérateur peut être utilisé pour comparer deux valeurs ?", "3 - ==" },
               { "4", "6. Pour déclarer un tableau en C#, définissez le type de variable avec :", "4 - <>" },
               { "3", "7. Quel type de variable est utilisé pour créer / stocker un chiffre ?", "3 - int" },
               { "1", "8. Quel est la syntax correcte pour réaliser une boucle de 10 itérations ?", "1 - for (int i = 1; i <= 10; i++)" },
               { "2", "9. Comment convertir une entrée console en variable de type entier ?", "2 - Convert.ToInt32(Console.ReadLine());" },
               { "2", "10. En quelle année le C# à-t-il été crée ?", "2 - 2001" }
            };



            List<string> correction = new List<string>(new string[] {});
            string answer = "";
            int note = 0; // intAnswer;
            QuizHelp QuizHelp = new QuizHelp();
            for (int i = 1; i <= 10; i++)
            {
                QuizHelp.FonQuiz(i);
                answer = Console.ReadLine();
                /*
                bool success = Int32.TryParse(answer, out intAnswer);
                if (success && intAnswer <= 4 && intAnswer >= 1) // ajouter verif intAnswer entre 1 et 4
                {
                    if (intAnswer == answers[i - 1])
                    {
                        note++;
                    }
                    correction.Add(intAnswer);
                }
                else
                {
                    Console.WriteLine("Erreur : entrée non conforme, essayes encore.");
                    i--;
                }
                */
                switch (answer)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        if (answer == goodAnswers[i-1,0])
                        {
                            note++;
                        }
                        correction.Add(answer);
                        break;
                    default:
                        Console.WriteLine("Erreur : entrée non conforme, essayes encore.");
                        i--;
                        break;
                }
            }
            Console.WriteLine($"Votre note est {note} / 10");
            if (note != 10 )
            {
                for (int e = 0; e < 10; e++)
                {
                    if (correction[e] == goodAnswers[e, 0])
                    {
                        Console.WriteLine($"A la Question {e + 1}, vous avez repondu juste.");
                    }
                    else
                    {
                        Console.WriteLine($"A la question {goodAnswers[e, 1]} votre reponse etait incorrect, la bonne reponse etait {goodAnswers[e, 2]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Félicitation, vous avez passé le test avec succès ! Vous êtes engagé !");
            }
        }
    }
}
