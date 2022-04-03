using System;

namespace Vetores_Matrizes
{
    class Exercicio54
    {
        static void Main1(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[8];

            Console.WriteLine("Programa que imprima todos os elementos comuns de dois vetores!\n\n");

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o "+(i + 1)+"º número no vetor A: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n");

            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + "º número no vetor B: ");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++) 
            for (int j = 0; j < 8; j++)
            {
                if (a[i] == b[j])
                {
                        Console.WriteLine($"{0}"+ b[j]);
                }
            }
             Console.ReadKey();
        }
    }
}
