using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{

    /*12 - Crie uma classe Personagem com os atributos nome, posição x, posição y, HP entre outros de sua preferência.
    Além disso, deve possuir o método RetornaPosiçao que retorna a posição x e y do personagem.Faça também com que possua os métodos abstratos Movimentar, Atacar.
    Crie uma classe NPC e PersonagemJogavel que implemente os métodos abstratos.*/

    abstract class Personagem
    {
        private string Nome;
        private float PosicaoX = 0;
        private float PosicaoY = 0;
        private int HP = 100;
        private int ItensColetados = 0;


        public abstract void Movimentar();
        public abstract void Atacar();


        public void coletar()
        {
            ItensColetados++;
        }
        public void caminhar()
        {
            PosicaoX++;
            PosicaoY++;
        }

        public float getPosiX()
        {
            return PosicaoX;
        }
        public float getPosiY()
        {
            return PosicaoY;
        }

        public string getNome()
        {
            return Nome;
        }
        public int getItensColetados()
        {
            return ItensColetados;
        }
        public int getHP()
        {
            return HP;
        }

        public void setHP(int val) 
        {HP = val;}
        public void setNome(string val)
        {Nome= val;}
        public void setPosiX(float val)
        {PosicaoX= val;}
        public void serPosiY(float val)
        { PosicaoY= val;}
        
    }
}
