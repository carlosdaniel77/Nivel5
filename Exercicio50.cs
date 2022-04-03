using System;

namespace Vetores_Matrizes
{
    class Exercicio50
    {
        static void Main1(string[] args)
        {
			Random numero = new Random();
			bool acertou = false;
			int chute;
			int	tentativas = 0;
			int numeroSorte = numero.Next(0,101);

			Console.WriteLine("Programa que sorteie um número de 0 a 100 e que permita que o usuário (sem conhecer o número sorteado) tente acertar!\n\n");

			while (acertou == false)
			{
				Console.WriteLine("Digite um número de 0 a 100: ");
				chute = Convert.ToInt32(Console.ReadLine());
				tentativas++;

				if (chute == numeroSorte)
				{
					Console.WriteLine("\nVocê acertou em " + tentativas + " tentativas!");
					acertou = true;
				}
				else if (chute > numeroSorte)
				{
					Console.WriteLine("\nO número é menor!");
				}
				else
				{
					Console.WriteLine("\nO número é maior!");
				}
			}
			Console.ReadKey();
        }
    }
}
