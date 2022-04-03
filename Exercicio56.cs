using System;
using System.Linq;

namespace Vetores_Matrizes
{
    class Exercicio56
    {
        static void Main1(string[] args)
        {
            uint[] num = new uint[50];
            int contPar = 0;
            int contMultiplo5 = 0;

            Console.WriteLine("Programa para ler um vetor de inteiros positivos de 50 posições!\n\n");

            for (int i=0;i<num.Length;i++)
            {
                Console.WriteLine("Informe um número inteiro e positivo para a "+(i + 1)+"º posição do vetor");
                
                num[i] = Convert.ToUInt32(Console.ReadLine());

                if (num[i] % 2 == 0)
                {
                    contPar++;
                }

                if (num[i] % 5 == 0)
                {
                    contMultiplo5++;
                }
            }
            Console.WriteLine($"Total de números pares:{contPar}\nTotal de números múltiplos de 5:{contMultiplo5} ");
            Console.ReadKey();
        }
    }
}
