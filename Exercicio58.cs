using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Matrizes
{
    class Exercicio58
    {
        static void Main1(string[] args)
        {
            uint tamanhoVet;
            uint maior = 0;
            double somaNum = 0;
            double media;

            Console.WriteLine("Programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média!\n\n");
            Console.WriteLine("Informe o tamanho do vetor: ");
            tamanhoVet = Convert.ToUInt32(Console.ReadLine());

            uint[] num = new uint[tamanhoVet];

            for (int i = 0; i < tamanhoVet; i++)
            {
                Console.WriteLine("\nInforme um número inteiro e positivo para a " + (i + 1) + "º posição do vetor");
                num[i] = Convert.ToUInt32(Console.ReadLine());
                if (i == 0)
                {
                    maior = num[i];
                }
                if (num[i] > maior)
                {
                    maior = num[i];
                }

                somaNum += num[i];
            }
            media = somaNum / tamanhoVet;
            media = Math.Round(media, 2);

            Console.WriteLine("\n\nO maior número é: "+ maior);
            Console.WriteLine("A média dos números é: "+ media);
            Console.ReadKey();
        }
    }
}
