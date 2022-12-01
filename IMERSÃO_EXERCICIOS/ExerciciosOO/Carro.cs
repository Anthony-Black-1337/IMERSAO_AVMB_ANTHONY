using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    internal class Carro
    {
        private string Modelo;
        private string Cor;
        private int Ano;
        private string Marca;
        private int Chassi;
        private string Proprietário;
        private int Velocidade_máxima;
        private int Velocidade_atual;
        private int Nr_de_portas;
        private bool tem_teto_solar;
        private int Nr_Marchas;
        private bool tem_câmbio_automático;
        private float Volume_de_combustível;


       
        public Carro(){}

        public void acelera()
        {
            if(Velocidade_atual < Velocidade_máxima)
            {
                Velocidade_atual++;
            }
           
        }
        public void freia()
        {
            if (Velocidade_atual > 0)
            {
                while(Velocidade_atual > 0)
                {
                    Velocidade_atual--;
                }
            }
        }

        public void trocaMarcha(int marcha)
        {
            if(marcha > 0 && marcha <= Nr_Marchas)
            {
                marcha++;
            }
        }
        public void resuzMarcha(int marcha)
        {
            if (marcha > 0 && marcha <= Nr_Marchas)
            {
                marcha--;
            }
        }

        public string getModelo()
        {
            return Modelo;
        }
        public string getCor()
        {
            return Cor; 
        }

        public int getMarcha()
        {
            return Nr_Marchas;
        }

        public int getAno()
        {
            return Ano;
        }

        public string getMarca()
        {
            return Marca;
        }

        public int getChassis()
        {
            return Chassi;
        }

        public string getProprietario()
        {
            return Proprietário;
        }
        
        public int getVeloMax()
        {
            return Velocidade_máxima;
        }

        public int getVeloAtual()
        {
            return Velocidade_atual;
        }

        public int getNrPortas()
        {
            return Nr_de_portas;
        }

        public bool getTemTeto()
        {
            return tem_teto_solar;
        }
        public int getNrMarcha()
        {
            return Nr_Marchas;
        }
        public bool getTemCambioAuto()
        {
            return tem_câmbio_automático;
        }
        public float getVolCombustivel()
        {
            return Volume_de_combustível;
        }
        public void setModelo(string modelo)
        {
            Modelo = modelo;
        }
        public void setCor(string cor)
        {
            Cor= cor;
        }
        public void setAno(int ano)
        {
            Ano = ano;
        }
        public void setMarca(string marca)
        {
            Marca = marca;
        }
        public void setChassis(int chassi)
        {
            Chassi = chassi;
        }
        public void setPropri(string propri)
        {
            Proprietário= propri;
        }
        public void setVeloMax(int veloMax)
        {
            Velocidade_máxima = veloMax;
        }
        public void setVeloAtual(int veloAtual)
        {
            Velocidade_atual= veloAtual;
        }
        public void setNrPorta(int nrPorta)
        {
            Nr_de_portas= nrPorta;
        }
        public void setTemTetoSolar(bool temteto)
        {
            tem_teto_solar= temteto;
        }
        public void setNrMarcha(int nMarcha)
        {
            Nr_Marchas = nMarcha;
        }
        public void setTemCambio(bool temcambio)
        {
            tem_câmbio_automático= temcambio;
        }
        public void setVolCombustivel(float volCombustivel)
        {
            Volume_de_combustível= volCombustivel;
        }
        
    }
}
