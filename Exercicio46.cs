using System;

namespace Vetores_Matrizes
{
    class Exercicio46
    {
        static void Main(string[] args)
        {
            int quantidade;
            Console.WriteLine("Programa que realiza a soma de todos os resultados da multiplicação!\n\n");
            Console.WriteLine("Informe a quantidade de números:");
            quantidade = int.Parse(Console.ReadLine());
            
            int[] vetx = new int[quantidade];
            int[] vety = new int[quantidade];

            for (int x = 0; x < quantidade ; x++)
            {
                Console.WriteLine("\nInforme o "+(x+1)+"° número do vetor X:");
                vetx[x] = Convert.ToInt32(Console.ReadLine());
            }

            for (int y = 0; y < quantidade; y++)
            {
                Console.WriteLine("\nInforme o " + (y + 1) + "° número do vetor Y:");
                vety[y] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nA multiplicação dos vetores é: \n");
            for(int w=0; w < quantidade; w++)
            {
                Console.WriteLine("O vetorX "+vetx[w]+" * vetorY "+vety[w]+" é: " + (vety[w] * vetx[w]));
            }
            Console.ReadKey();   
        }
    }
}
