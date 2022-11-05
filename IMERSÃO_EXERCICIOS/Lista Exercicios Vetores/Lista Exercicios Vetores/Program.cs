using System;
using System.Net;

namespace Lista_Exercicios_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /*1.	Escreva um algoritmo que leia os valores para um vetor de 10
            //elementos e então mostre na tela a quantidade de números pares e ímpares.

            int[] vet = new int[10];
            int par = 0, impar = 0;

            Console.WriteLine("\nEscreva 10 numeros !\n\n");


            for (int i = 0; i < 10; i++)
            {

                Console.Write("Escreva o " + i + "º numero /:");
                vet[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < 10; i++)
            {
                if(vet[i] %2 == 0)
                {
                    par++;
                }
                if (vet[i] % 2 != 0)
                {
                    impar++;
                }
            }
            Console.Write("\nPares :"+par+"\n"+"Impares :" + impar + "\n");

            */
            /* 2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a
            // soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.


            int[] v1 = new int[20];
            int[] v2 = new int[20];
            int[] v3 = new int[20];

            Console.Write("\nVetor 1\n");

            for (int i = 0; i < 20; i++)
            {

                Console.Write("Escreva o " + i + "º numero /:");
                v1[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("\nVetor 2\n");

            for (int i = 0; i < 20; i++)
            {

                Console.Write("Escreva o " + i + "º numero /:");
                v2[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < 20; i++)
            {

               v3[i] = v1[i] + v2[i];

            }

            for (int i = 0; i < 20; i++)
            {

                Console.Write(v3[i]+"\n");
            }
            */

            //3-Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição
            //dos valores correspondentes a números primos.

            int[] v4 = new int[20];

            for (int i = 0; i < 5; i++)
            {

                Console.Write("Escreva o " + i + "º numero /:");
                v4[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("\n\n");

            for (int i = 0; i < 5; i++)
            {

                for (int j = 2; j <= v4[i] / 2; i++)
                {
                    if (v4[i] % i == 0)
                    {
                        
                        
                    }


                }

            }
        }
    }
}