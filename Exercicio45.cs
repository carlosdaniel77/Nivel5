using System;

namespace Vetores_Matrizes
{
    class Exercicio45
    {
        static void Main1(string[] args)
        {
            int n;
            Console.WriteLine("Programa que dada uma seqüência de n números, imprimi-la na ordem inversa!\n\n");
            Console.WriteLine("Informe o tamanho do vetor:");
            n = int.Parse(Console.ReadLine());
            
            int[] vet = new int[n];
            for (int i = 0; i < vet.Length ; i++)
            {
                Console.WriteLine("\nInforme um número:");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = vet.Length;i>=0; i--)
            {
                Console.WriteLine("Ordem inversa:" + i);
            }      
            Console.ReadKey();   
        }
    }
}
