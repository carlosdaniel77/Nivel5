using System;

namespace Vetores_Matrizes
{
    class Exercicio49
    {
        static void Main1(string[] args)
        {
            uint tamanhoVet;
            Console.WriteLine("Programa que determina e imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições!\n\n");
            Console.WriteLine("Digite o tamanho do vetor (limite máximo = 50):");
            tamanhoVet = uint.Parse(Console.ReadLine());
            if(tamanhoVet >= 0 && tamanhoVet <= 50)
            {
                int[] v1 = new int[tamanhoVet];
                int[] v2 = new int[tamanhoVet];

                for(int i = 0; i < tamanhoVet; i++)
                {
                    Console.WriteLine("\nInforme um número inteiro para a posição "+ (i+1) +" do vetor v1:");
                    v1[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nInforme um número inteiro para a posição " + (i + 1) +" do vetor v2:");
                    v2[i] = Convert.ToInt32(Console.ReadLine());
                    if(v1[i] == v2[i])
                    {
                        Console.WriteLine($"\nO valor {v1[i]} da posição "+(i+1)+$" do vetor V1 é igual ao valor {v2[i]} da posição "+(i+1)+" do vetor V2.");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nTamanho do vetor nulo!");
            }
            Console.ReadKey();
        }
    }
}
