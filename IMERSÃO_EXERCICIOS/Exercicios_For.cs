using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Lista_de_Exercicios_3_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10 - Faça um programa que leia um número e apresente a tabuada deste número.

            int i, num;

            Console.WriteLine("Digite um numero /:");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTabuada do " + num + "\n");

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + i*num);
            }
            */

            /* 11 - Escreva um programa em C# que gera números entre 1000 e 1999 e
            // mostra aqueles que divididos por 11 dão resto 5.

            int MAX = 1999;

            for (int i = 1000; i < MAX; i++)
            {
                if(i % 11 == 5)
                {
                    Console.WriteLine(i + "  Dividido por 11 o resto é 5 !");
                }
            }*/

            /*12 - Dado um limite inferior e superior, calcule a soma de todos os números
            // pares contidos nesse intervalo.

            int a, b;
            int infe = 0, supe = 0, soma = 0;

            Console.WriteLine("Digite dois numeros /: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                infe = a;
                supe = b;
            }
            else
            if(b < a)
            {
                infe = b;
                supe = a;
            }
            else
            {
                Console.WriteLine("Numeros Iguais !!! ");
            }

            for (int k = infe; k <= supe; k++)
            {
                if(k % 2 == 0)
                {
                    soma = soma + k;
                }
            }

            Console.WriteLine("A soma dos numeros pares é " + soma);

            */
            //18 - Utilize o comando break no código abaixo de modo que o laço pare em 5.

            //19 - Utilize o comando continue de modo que as voltas de número 5 e 7 sejam puladas
            //no código da questão anterior.
            /*
            int i;

            for (i = 0; true; i++)

            {
            
                if(i == 5)
                {
                    break;
                }

                if(i == 5 || i == 7)
                {
                    continue;
                }
                Console.WriteLine("Volta numero :" + i);

                if (i == 10)
                {
                    break;
                }
            }*/

            /*int i, j;

            for(i = 0; i < 20; i++)
            {
                Console.WriteLine("i: "+ i);
                for (j = 0; j<10; j++)
                {
                    Console.WriteLine("     j: " + j);
                }
            }
           
            */

        }
    }
}