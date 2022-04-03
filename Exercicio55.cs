using System;
using System.Linq;

namespace Vetores_Matrizes
{
    class Exercicio55
    {
        static void Main1(string[] args)
        {
            int cont = 0;
            int contadorLetras = 0;
            string frase;
            string novafrase;
            Console.WriteLine("Programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco!\n\n");
            Console.WriteLine("Informe uma frase: ");
            frase = Console.ReadLine();

            foreach (var letra in frase)
            {
                contadorLetras = frase.IndexOf(' ');

                if (letra.Equals(' '))
                {
                    cont++;
                }
            }

            Console.WriteLine("\nTotal de espaços encontrado em branco na frase:"+ cont);
            novafrase = String.Concat(frase.Where(c => !Char.IsWhiteSpace(c)));

            Console.WriteLine("\nFrases sem espaço em branco:\n"+ novafrase);
            Console.ReadKey();
        }
    }
}
