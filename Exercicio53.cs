using System;

namespace Vetores_Matrizes
{
    class Exercicio53
    {
        static void Main1(string[] args)
        {
            int numVolta;
            int total = 0;
            int media;
            int melhorTempo = 0;
            int melhorVolta = 0;

			Console.WriteLine("Programa que ler os tempos das N voltas!\n\n");
			Console.WriteLine("Digite o número de voltas: ");
			numVolta = Convert.ToInt32(Console.ReadLine());

			int[] tempos = new int[numVolta];
			for (int x = 0; x < numVolta; x++)
			{
				Console.WriteLine("\nDigite o tempo da " + (x + 1) + "ª volta (em segundos): ");
				tempos[x] = Convert.ToInt32(Console.ReadLine());
				total += tempos[x];
				if (tempos[x] < melhorTempo || x == 0)
				{
					melhorTempo = tempos[x];
					melhorVolta = x + 1;
				}
			}
			media = total / numVolta;


			Console.WriteLine("\n\ni.   O melhor tempo foi: " + melhorTempo + " segundos.");
			Console.WriteLine("ii.  Melhor volta foi a " + melhorVolta + "ª.");
			Console.WriteLine("iii. A média de tempo foi: " + media);
			Console.ReadKey();
        }
    }
}
