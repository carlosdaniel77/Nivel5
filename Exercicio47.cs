using System;

namespace Vetores_Matrizes
{
    class Exercicio47
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            Console.WriteLine("Programa de vetor de números inteiros!\n\n");
            
            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Informe o "+(x+1)+"° número do vetor: ");
                vet[x] = Convert.ToInt32(Console.ReadLine());
            }

            int numeroX;
            Console.WriteLine("\n\nInforme o número de X:");
            numeroX = Convert.ToInt32(Console.ReadLine());

            int maiores = 0;
            int menores = 0;
            int iguais = 0;
            Console.WriteLine("\nNúmeros maiores que o número X:\n");
            for (int w = 0; w < 10; w++)
            {
                if (vet[w] > numeroX)
                {
                    Console.WriteLine(" " + vet[w]);
                    maiores++;
                }else if (vet[w] == numeroX)
                {
                    iguais++;
                }
                else
                {
                    menores++;
                }
            }
            Console.WriteLine("\nMaiores:" + maiores + "\nIguais: " + iguais + "\nMenores: " + menores + "\n");
            Console.ReadKey();   
        }
    }
}
