

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Lista_de_Exercicios_Arquivos
{
   
    internal class Program
    {
        class Arquivo
        {
            StreamWriter sw;
            StreamReader sr;
            string email, nome;

           
            public void cria_arquivo()
            {
                sw = new StreamWriter("G:\\Meu Drive\\PROJETOS\\Lista de Exercicios Arquivos\\Lista de Exercicios Arquivos\\arquivos\\emails.txt", true);
            }

            public void ler_arquivo()
            {
                string linha;
                sr = new StreamReader("G:\\Meu Drive\\PROJETOS\\Lista de Exercicios Arquivos\\Lista de Exercicios Arquivos\\arquivos\\emails.txt");
                linha = sr.ReadLine();

                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = sr.ReadLine();
                }
                sr.Close();
            }

            public void grava_email(string email)
            {
                sw.WriteLine(email);
            }

            public void fecha_arquivo()
            {
                sw.Close();
            }
        }
           

            static void Main(string[] args)
            {
            try
            {
                int op;
                string email;
                bool e = true;
                Arquivo a = new Arquivo();

                while(e != false)
                {
             
                    Console.Write("\n\n      Menu\n\n1 - Cadastrar email\n2 - Listar\n3 - Sair\n\n");
                    Console.Write("Opção: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            a.cria_arquivo();
                            Console.WriteLine("Digite o E-mail OU digite SAIR /: ");
                            while(true)
                            {
                                email = Console.ReadLine();

                                if(email.Equals("SAIR"))
                                {
                                    a.fecha_arquivo();
                                    break;
                                }
                                else
                                {
                                    a.grava_email(email);
                                }
                            }
                            break;
                        case 2:

                            a.ler_arquivo();

                            break;
                        case 3:

                            e = false;
                           
                            break;
                    }
                }                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\n\nVOCÊ SAIU DO PROGRAMA !!!\n\n");
            }
        }
    }
}