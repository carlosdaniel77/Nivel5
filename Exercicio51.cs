using System;

namespace Vetores_Matrizes
{
    class Exercicio51
    {
        static void Main1(string[] args)
        {
			int quantidadeAlunos;
			int	notasBoas = 0; //notas boas são consideradas quando a nota é maior que 7.
			bool salaRuim = true;//salaRuim quando ninguém tirou nota maior que 5.

			Console.WriteLine("Programa para ler uma quantidade N de alunos!\n\n");
			Console.WriteLine("Digite a quantidade de alunos: ");
			quantidadeAlunos = Convert.ToInt32(Console.ReadLine());

			int[] notas = new int[quantidadeAlunos];

			for (int x = 0; x < quantidadeAlunos; x++)
			{
				Console.WriteLine("Digite a nota do " + (x + 1) + "° Aluno: ");
				notas[x] = Convert.ToInt32(Console.ReadLine());

				if (notas[x] > 7)
				{
					notasBoas++;
				}
				if (notas[x] > 5)
				{
					salaRuim = false;
				}
			}

			if (salaRuim == false)
			{
				Console.WriteLine("Existem " + notasBoas + " notas maiores que 7.");
			}
			else
			{
				Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
			}

			Console.ReadKey();
        }
    }
}
