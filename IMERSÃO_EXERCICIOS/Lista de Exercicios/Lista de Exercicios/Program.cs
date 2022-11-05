namespace Lista_de_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, r;

            
            a = 10;
            b = 5;
          

            // SOMA 

            r = a + b;
            Console.WriteLine("Soma "+ r);

            // SUBTRAÇÃO 

            r = a - b;
            Console.WriteLine("Subtração " + r);

            // MULTIPLICAÇÃO

            r = a * b;
            Console.WriteLine("Multiplicação " + r);

            // Divisão

            r = a / b;
            Console.WriteLine("Divisão " + r);

            // Area de um retangulo 

            float basi, altura, result;
            basi = 10;
            altura = 4;

            result = basi * altura;

            Console.WriteLine("Area de um retangulo: " + result);

            // Area de um retangulo equilatero

            result = (basi * altura) / 2;

            Console.WriteLine("Area de um retangulo equilatero: " + result);

            // Calcular a area de um circulo

            double raio, pi = 3.14, resultado;

            Console.WriteLine("Digite o raio da operação /: ");
            raio = double.Parse(Console.ReadLine());

            resultado = pi * (raio * raio);

            Console.WriteLine("A area de um circulo /: " + resultado);

            // Idade de uma pessoa

            int idade, ano;

            Console.WriteLine("Digite sua idade /: ");
            idade = int.Parse(Console.ReadLine());

            ano = 2022 - idade;

            Console.WriteLine("Nasceu no ano de /:" + ano);
        }

    }
}