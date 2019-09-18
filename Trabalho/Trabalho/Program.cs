using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
                        
            Boolean continua = true;

            List<Menu> listaMenu = new List<Menu>();



            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("--Menu de cadastro--");
                Console.WriteLine(" 01 - Incluir");
                Console.WriteLine(" 02 - Alterar");
                Console.WriteLine(" 03 - Excluir");
                Console.WriteLine(" 04 - Listar");
                Console.WriteLine(" 05 - Pesquisar");
                Console.WriteLine(" 06 - Sair ");
                Console.WriteLine("Digite sua opção:");
                
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "01":

                        Console.WriteLine("Cadastro de pessoa");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Senha com numero: ");
                        int senha = Convert.ToInt32(Console.ReadLine());
                        Console.Write("id: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        listaMenu.Add(new Menu(nome, senha, id));
                        break;


                    case "02":
                        Console.WriteLine("Alterar");
                        Console.WriteLine("Indique o registro a ser alterado (ID): ");
                        int alterarNome = int.Parse(Console.ReadLine());
                        Menu alterar = listaMenu.Find(x => x.Id == alterarNome);



                        if(alterarNome != null)
                        {
                            Console.Write("Informe o novo Nome: ");
                            string novoNome = Console.ReadLine();
                            alterar.alteraNome(novoNome);
                            Console.WriteLine("Nome atualizado: " + novoNome);
                            

                        }
                        else
                        {
                            Console.WriteLine(" ¨¨Registro não existe¨¨ ");
                        }


                        break;
                    case "03":
                        Console.WriteLine("Excluir");
                        Console.WriteLine("Indique o registro a ser excluido (Id): ");
                        int excluirNome = int.Parse(Console.ReadLine());
                        if(excluirNome  <= listaMenu.Count)
                        {
                            listaMenu.RemoveAt(excluirNome);
                        }
                        else
                        {
                            Console.WriteLine("item não existe na lista");
                        }


                        break;
                    case "04":
                        Console.WriteLine("Listar");
                        Console.WriteLine("Id - Senha. - Nome - Id\n");
                        
                        for (int i = 0; i< listaMenu.Count; i++)
                        {
                              foreach (Menu p in listaMenu )
                               {
                                Console.WriteLine($"{i++} - {p.Nome} - {p.Senha} - {p.Id}");
                               }
                        }

                        break;
                    case "05":
                        Console.WriteLine("Pesquisar");
                        Console.WriteLine("Inserir o Nome do registro que deseja pesquisar ");
                        string src = Console.ReadLine();
                        Menu pesq = listaMenu.Find(x => x.Nome == src);
                        if(pesq != null)
                        {
                            Console.WriteLine("Id: { pesq.Senha}");
                            Console.WriteLine("Id: { pesq.Nome}");
                            Console.WriteLine("Id: { pesq.Id}");
                        }

                        break;
                    case "06":
                        Console.WriteLine("Sair");
                        continua = false;
                        break;

                    default:
                        Console.WriteLine("opcão nao existente.");
                        break;

                }
            }

            while (continua);
            
        }
    }
}
