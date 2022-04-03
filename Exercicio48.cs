using System;

namespace Vetores_Matrizes
{
    class Exercicio48
    {
        static void Main1(string[] args)
        {
            int numeroCandidatas = 5;
            int quantidade_aptas = 0;
            string[] nome = new string[numeroCandidatas];
            int[] idade = new int[numeroCandidatas];

            Console.WriteLine("Programa para imprima o vetor que contém os nomes das candidatas aptas a concorrer a uma vaga para a campanha milionária!\n\n");

            for (int x = 0; x < numeroCandidatas; x++)
            {
                Console.WriteLine("Digite o nome da " + (x + 1) + "ª candidata: ");
                nome[x] = Console.ReadLine();

                Console.WriteLine("Digite a idade da " + (x + 1) + "ª candidata: ");
                idade[x] = Convert.ToInt32(Console.ReadLine());

                if (idade[x] >= 18 && idade[x] < 21)
                {
                    quantidade_aptas++;
                }
            }

            String[] nome_aptas = new String[quantidade_aptas];
            int[] idade_aptas = new int[quantidade_aptas];

            int y = 0;
            for (int x = 0; x < numeroCandidatas; x++)
            {
                if (idade[x] >= 18 && idade[x] < 21)
                {
                    nome_aptas[y] = nome[x];
                    idade_aptas[y] = idade[x];
                    y++;
                }
            }

            Console.WriteLine();

            for (int x = 0; x < quantidade_aptas; x++)
            {
                Console.WriteLine($"Nome: {x} \tIdade: {x}\n", nome_aptas[x], idade_aptas[x]);
            }
        }
    }
}
