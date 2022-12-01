using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    internal class pessoaFisica : Pessoa
    {
        
        public override void CadastrarPessoa()
        {
            Console.WriteLine("Digite o Nome:");
            string nome = Console.ReadLine();
            setNome(nome);

            Console.WriteLine("Digite o CPF:");
            string cpf = Console.ReadLine();
            setCPF(cpf);

            Console.WriteLine("Digite o RG:");
            string rg = Console.ReadLine();
            setRG(rg);

            Console.WriteLine("Digite a data de nacimento:");
            string data = Console.ReadLine();
            setDataNasc(data);

        }
    }
}
