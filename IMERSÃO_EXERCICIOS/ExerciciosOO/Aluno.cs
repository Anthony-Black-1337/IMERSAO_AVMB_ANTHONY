using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Escreva uma classe Aluno contendo todos os atributos de um aluno. Faça métodos para apresentar os dados.
// Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.

namespace ExerciciosOO
{
    internal class Aluno
    {
        private int    idAluno;
        private string nomeAluno;
        private int    idadeAluno;
        private string serieAluno;
        private string nacionalidade;

        public Aluno()
        {
        }

        public int getIdAluno()
        {
            return idAluno;
        }
        public string getNomeAluno()
        {
            return nomeAluno;
        }
        public int getIdadeAluno() 
        {
            return idadeAluno;
        }
        
        public string getSerieAluno() 
        {
            return serieAluno;
        }
        public string getNacionalidade()
        {
            return nacionalidade;
        }

        public void setIdAluno(int id)
        {
            idAluno = id;
        }
        public void setNomeAluno(string nome)
        {
            nomeAluno = nome;
        }
        public void setIdadeAluno(int idade)
        {
            idadeAluno = idade;
        }

        public void setSerieAluno(string serie)
        {
             serieAluno = serie;
        }
        public void setNacionalidade(string nacio)
        {
            nacionalidade = nacio;
        }

        public void preencheDadosAlunos()
        {
            Console.WriteLine("Digite o nome do Aluno /:");
            nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite o ID do Aluno /:");
            idAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade do Aluno /:");
            idadeAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a serie do Aluno /:");
            serieAluno =    Console.ReadLine();

            Console.WriteLine("Digite a nacionalidade do Aluno /:");
            nacionalidade = Console.ReadLine();

        }
        public void mostraDadosAlunos()
        {
            Console.WriteLine(nomeAluno);
            Console.WriteLine(idAluno);
            Console.WriteLine(idadeAluno);
            Console.WriteLine(serieAluno);
            Console.WriteLine(nacionalidade);
        }

    }
}
