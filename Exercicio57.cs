using System;
using System.Linq;

namespace Vetores_Matrizes
{
    class Exercicio57
    {
        static void Main1(string[] args)
        {
            string frase;
            string fraseNova = "";

            Console.WriteLine("Programa que leia uma frase e imprima somente as vogais!\n\n");
            Console.WriteLine("Informe uma frase:");
            frase = Console.ReadLine();


            foreach (var vogal in frase)
            {
                if (vogal == 'A' || vogal == 'a')
                {
                    fraseNova += 'a';
                }
                if (vogal == 'E' || vogal == 'e')
                {
                    fraseNova += 'e';
                }
                if (vogal == 'I' || vogal == 'i')
                {
                    fraseNova += 'i';
                }
                if (vogal == 'O' || vogal == 'o')
                {
                    fraseNova += 'o';
                }
                if (vogal == 'U' || vogal == 'u')
                {
                    fraseNova += 'u';
                }
            }

            Console.WriteLine("\nFrase digitada apenas com vogais:\n"+ fraseNova);
            Console.ReadKey();
        }
    }
}
