using static System.Net.Mime.MediaTypeNames;

namespace Lista_de_Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            /*LEIA QUATRO VALORES INTEIROS CALCULE SUA MEDIA E ESCREVA OS VALORES A CIMA DA MEDIA 

            int v1, v2, v3, v4, media;

            Console.WriteLine("Digite o valor 1 /: ");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2 /: ");
            v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 3 /: ");
            v3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 4 /: ");
            v4 = int.Parse(Console.ReadLine());

            media = (v1 + v2 + v3 + v4) / 4;

            Console.WriteLine("\n A media é /: " + media + "\n");

            if (media < v1)
            {
                Console.WriteLine(v1+" Esta acima da media !");
            }
            if (media < v2)
            {
                Console.WriteLine(v2 + " Esta acima da media !");
            }
            if (media < v3)
            {
                Console.WriteLine(v3 + " Esta acima da media !");
            }
            if (media < v4)
            {
                Console.WriteLine(v4 + " Esta acima da media !");
            }

            */

            /*Mostrar na tela qual dos professores tem o maior salário total.

            float prof1, prof2, valorhora1, valorhora2, salario1, salario2;

            Console.WriteLine("Horas aula dadas, professor 1 /:");
            prof1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Horas aula dadas, professor 2 /:");
            prof2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor por Hora aula, professor 1 /:");
            valorhora1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor por Hora aula, professor 2 /:");
            valorhora2 = float.Parse(Console.ReadLine());

            //professor 1 

            salario1 = prof1 * valorhora1;

            //professor 2 

            salario2 = prof2 * valorhora2;


            if(salario1 > salario2) 
            {
                Console.WriteLine("Professor 1 tem o salario maior !");
            }else
            if (salario2 > salario1)
            {
                Console.WriteLine("Professor 2 tem o salario maior !");
            }else
            if (salario2 == salario1)
            {
                Console.WriteLine("Professor 1 e professor 2 recebem  o mesmo valor salario !");
            }
            */
            /* de 1 a 12 validar entrada

            int entrada;

            Console.WriteLine("Digite um valor entre 1 e 12");
            entrada = int.Parse(Console.ReadLine());

            if (entrada <=0 || entrada > 12)
            {
                Console.WriteLine("Digite um valor entre 1 e 12 /:");
                entrada = int.Parse(Console.ReadLine());
                return;
            }
            */

            /*9 - Faça um algoritmo que leia o tamanho dos lados de um triangulo
            //(lado a, b e c), e então diga se esses lados podem ou não formar um triangulo.
            //Para que os lados formem um triângulo, todos os lados devem ser menores a soma
            //dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo
            //é equilátero (todos os lados iguais), isoceles (somente 2 lados são iguais)
            //ou escaleno (os 3 lados são diferentes).


            //ler lados de um triangulo

            float lado_a, lado_b, lado_c;
            int cont = 0;
            Console.WriteLine("Digite 3 lados de um triangulo /:");
            lado_a = float.Parse(Console.ReadLine());
            lado_b = float.Parse(Console.ReadLine());
            lado_c = float.Parse(Console.ReadLine());

            //forma triangulo 

            if(lado_a < lado_b + lado_c)
            {
                cont++;
            }
             if (lado_b < lado_a + lado_c)
            {
                cont++;
            }
           
             if (lado_c < lado_b + lado_a)
            {
                cont++;
            }

            if (cont == 3)
            {
                if (lado_a == lado_b && lado_a == lado_c && lado_b == lado_c)
                {
                    Console.WriteLine("É um triangulo Equilatero !");
                }
                if (lado_a == lado_b && lado_a != lado_c || lado_b == lado_c && lado_b != lado_a)
                {
                    Console.WriteLine("É um triangulo Isoceles !");
                }
                if (lado_a != lado_b && lado_a != lado_c && lado_b != lado_c)
                {
                    Console.WriteLine("É um triangulo Escaleno !");
                }
            }
            */
        }
    }
}