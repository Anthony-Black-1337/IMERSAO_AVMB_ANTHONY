namespace ExerciciosOO
{
   internal class OO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agora!@");
            Lampada l1 = new Lampada(200, "azul");
            Livro livro = new Livro("Anthony", "ACAO");
            Disciplina dis = new Disciplina("Lab 1", 60);
            Motor motor = new Motor();
            Cachorro dog = new Cachorro(); 
            Gato cat = new Gato();
            Aluno aluno = new Aluno();
            Carro carro = new Carro();
            pessoaFisica f = new pessoaFisica();
            pessoaJuridica j = new pessoaJuridica();

            f.CadastrarPessoa();
            j.CadastrarPessoa();

            l1.potencia = 200;
            l1.ligar();
            l1.desligar();

            livro.ISBN = 123456789;
            livro.Autor = "ANTHONY";
            livro.Titulo_Livro = "Anotework";
            livro.Ano = 2022;
            livro.Cate = "Acao";
            livro.N_paginas= 1000;
            dis.mostradados();

            motor.recebevalor("mercedes", 500, "V8");

            Console.WriteLine(motor.retorNomeFabri);
            Console.WriteLine(motor.retornaTipomotor);
            Console.WriteLine(motor.retornaPotencia);

            dog.treinar();
            cat.treinar();

            aluno.preencheDadosAlunos();
            aluno.mostraDadosAlunos();
            Console.WriteLine();

            string pegamodelo = "ahdbvgwad"; 

            carro.setModelo(pegamodelo);

            Console.WriteLine(carro.getModelo());
        }
        
    }
}