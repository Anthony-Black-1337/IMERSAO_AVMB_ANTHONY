using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    abstract class Pessoa
    {
        private string Nome;
        private string CPF;
        private string DatadeNascimento;
        private string RG;
        private string CNPJ;

        public Pessoa() { }
        public abstract void CadastrarPessoa();
        public void apresentadados()
        {
            Console.WriteLine(Nome + CPF + DatadeNascimento + RG);
        }

        public string getNome()
        {
            return Nome;
        }
        public string getCPF()
        {
            return CPF;
        }
        public string getCNPJ()
        {
            return CNPJ;
        }
        public string getDatadeNascimento()
        {
            return DatadeNascimento;
        }
        public string getRG()
        {
            return RG;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public void setCPF(string cpf)
        {
            this.CPF = cpf;
        }
        public void setCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
        }
        public void setDataNasc(string data)
        {
            this.DatadeNascimento = data;
        }
        public void setRG(string rg)
        {
            this.RG = rg;
        }
    }
}
