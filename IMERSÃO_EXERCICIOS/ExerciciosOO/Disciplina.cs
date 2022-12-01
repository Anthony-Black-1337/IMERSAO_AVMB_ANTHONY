using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    internal class Disciplina
    {
        public string NomeDisciplina;
        public int CargaHoraria;

        public Disciplina(string Nome,int Carga)
        {
            this.NomeDisciplina = Nome;
            this.CargaHoraria = Carga;
        }

        public void mostradados()
        {
            Console.WriteLine(NomeDisciplina+CargaHoraria);
        }
                    
    }
}
