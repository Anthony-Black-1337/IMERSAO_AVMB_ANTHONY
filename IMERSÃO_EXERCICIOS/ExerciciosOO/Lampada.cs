using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    internal class Lampada
    {
        public double potencia;
        public bool ligado;
        public string cor;

        public Lampada(double potencia, string cor)
        {
            this.potencia = potencia;
            this.cor = cor;
        }
      
        public void desligar()
        {
            if (!estaligada())
            {
                ligado = false;
                Console.WriteLine("Desligando a lampada");

            }
            else
            {
                Console.WriteLine("Ja esta desligado!");
            }
        }
        public void ligar()
        {
            if(!estaligada())
            {
                ligado = true;
                Console.WriteLine("Ligando a lampada");

            }
            else
            {
                Console.WriteLine("Ja esta ligada!");
            }
        }
        public bool estaligada()
        {
            return ligado;
        }
    }
}
