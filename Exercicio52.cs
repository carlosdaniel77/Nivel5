using System;

namespace Vetores_Matrizes
{
    class Exercicio52
    {
        static void Main1(string[] args)
        {
            int tamanhoVet = 100;
            int[] num = new int[tamanhoVet];
            int contador = 0;
            int numero;

            Console.WriteLine("Programa para ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número 1, 3 e 4, nesta ordem!\nSe você digitar -1 sairá do programa.\n\n");
            
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Informe um número inteiro e positivo para a " + (i + 1) + "º posição do vetor");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == -1)
                {
                    i = 100;
                    tamanhoVet = i;
                }
                else
                {
                    num[i] = numero;
                }
            }

            for(int i = 0; i < num.Length; i++)
            {
                if(num[i] == 1 && num[i + 1] == 3 && num[i + 2 ] == 4)
                {
                    contador++;
                }
            }
            Console.WriteLine("\n\nA ordem 1, 3, 4 aconteceu " + contador + " vezes!");
            Console.ReadKey();
        }
    }
}
