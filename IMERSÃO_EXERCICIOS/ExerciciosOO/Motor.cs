using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    internal class Motor
    {
        private string NomeFabricante;
        private int potencia;
        private string tipomotor;

        public void recebevalor(string nome, int pot, string tipo) 
        {
            this.NomeFabricante= nome;
            this.potencia= pot;
            this.tipomotor= tipo;
        }
        public string retorNomeFabri()
        {
            return NomeFabricante;
        }
        public int retornaPotencia()
        {
            return potencia;
        }
        public string retornaTipomotor()
        {
            return tipomotor;
        }
    }
}
