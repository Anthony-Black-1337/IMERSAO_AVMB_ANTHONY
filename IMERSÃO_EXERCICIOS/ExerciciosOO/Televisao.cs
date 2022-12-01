using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    internal class Televisao
    {
        public string MarcaTV;
        public bool Ligada;
        public int Voltagem;
        public int Canais = 0;
        public bool BotaoTrocaCanal;
        public void desligar()
        {
            Ligada = false;
        }
        public void EstaLigada()
        {
            Ligada = true;
        }
        public void TrocaCanal(bool trocacanal)
        {
            if (trocacanal == true)
            {
                Canais++;
            }
            if (trocacanal == false)
            {
                Canais--;
            }
        }
    }
}
