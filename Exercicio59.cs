using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Matrizes
{
    class Exercicio59
    {
        static void Main1(string[] args)
        {
            string letra1;
            string letra2;
            string letra1Upper;
            string letra2Upper;
            int numCaracteres;
            string letrasAlfabeto = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            string[] alfabeto = new string[25];
            alfabeto = letrasAlfabeto.Split();

            Console.WriteLine("Programa que solicite dois caracteres de A a Z ao usuário e imprima o número de caracteres existente entre eles!\n\n");
            Console.WriteLine("Informe o primeiro caractere :");
            letra1 = Console.ReadLine();
            letra1Upper = letra1.ToUpper();


            Console.WriteLine("\nInforme o segundo caractere :");
            letra2 = Console.ReadLine();
            letra2Upper = letra2.ToUpper();

            numCaracteres = (Array.IndexOf(alfabeto, letra2Upper) - Array.IndexOf(alfabeto, letra1Upper)) - 1;
            if (numCaracteres < 0)
            {
                Console.WriteLine("\nErro!");
            }
            else
            {
                Console.WriteLine("\nO número de caracters entre eles é : "+ numCaracteres);
            }
        }
    }
}
