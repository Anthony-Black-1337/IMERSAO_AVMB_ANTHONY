using EntityCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;

namespace EntityCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:\n"+
                "1 para criar uma pessoa\n"+
                "2 para alterar o nome da pessoa\n"+
                "3 para inserir um email\n"+
                "4 para excluir uma pessoa\n"+
                "5 para consultar tudo\n"+
                "6 para consultar pelo ID\n");

            int op = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();
            
            switch (op)
            {
                    case 1:
                    try
                    {
                        Console.WriteLine("Inserir o nome da pessoa:");
                        Pessoa p = new Pessoa();
                        p.Nome = Console.ReadLine();

                        Console.WriteLine("Informe um email:");
                        string emailTemp = Console.ReadLine();

                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };
                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();

                        Console.WriteLine("Pessoa inserida com sucesso !");
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                    case 2:
                    try
                    {
                        
                        Console.WriteLine("Informe o ID da pessoa:"); 
                        
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pAlt = contexto.Pessoas.Find(id);

                        System.Console.WriteLine("Informe o nome correto: "); 
                        
                        pAlt.Nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);

                        contexto.SaveChanges();
                        Console.WriteLine("Pessoa inserida com sucesso !");
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    break;
                    case 3:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");

                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informe o novo email: ");

                        string emailTemp = Console.ReadLine();

                        p.Emails = new List<Email>() 
                        {

                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        contexto.Pessoas.Update(p);

                        contexto.SaveChanges();

                        Console.WriteLine("Pessoa inserida com sucesso !");
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break; 
                    case 4:
                    try
                    {
                        Console.WriteLine(" Informar o ID da pessoa");

                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine(" Confirmar a exclusão de" + p.Nome);
                        Console.WriteLine(" E dos seus emails: ");

                        foreach (Email item in p.Emails)
                        {

                            Console.WriteLine(" \t" + item.email);

                        }

                        Console.WriteLine(" 1 para SIM e outra tecla para NÃO"); 

                        if (int.Parse(Console.ReadLine()) == 1 )
                        {
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges(); 
                            Console.WriteLine(p.Nome + " excluída com sucesso!");
                        }
                        else
                        {
                            return;
                        }
                    } 
                    
                    catch (Exception)
                    {

                        throw;
                    }
                    break; 
                    case 5:
                    try
                    {
                        List<Pessoa> lista = (from Pessoa p in contexto.Pessoas select p).Include(pes => pes.Emails).ToList<Pessoa>(); 

                        foreach (Pessoa item in lista) 
                        {
                            Console.WriteLine(item.Nome);

                            foreach (Email itemE in item.Emails)
                            {
                                Console.WriteLine("\t" + itemE.email);
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                    case 6:
                    try
                    {
                        Console.WriteLine("Informe o id da pessoa"); 
                        int idPessoa = int.Parse(Console.ReadLine()); 
                        Pessoa pessoa = contexto.Pessoas.Include(p => p.Emails).FirstOrDefault(x => x.Id == idPessoa);

                        Console.WriteLine(pessoa.Nome);

                        if (pessoa.Emails != null)

                        {
                            foreach (Email item in pessoa.Emails
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                    catch (Exception)
                    { 
                        throw;
                    }
                    break;
            }
         


        }
    }
}