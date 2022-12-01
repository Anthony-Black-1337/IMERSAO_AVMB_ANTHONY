using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    internal class pessoaJuridica : Pessoa
    {
        public override void CadastrarPessoa()
        {
            Console.WriteLine("Digite o Nome:");
            string nome = Console.ReadLine();
            setNome(nome);

            Console.WriteLine("Digite o CNPJ:");
            string cnpj = Console.ReadLine();
            setCNPJ(cnpj);


            Console.WriteLine("Digite a data de nacimento:");
            string data = Console.ReadLine();
            setDataNasc(data);

        }
    }
}
