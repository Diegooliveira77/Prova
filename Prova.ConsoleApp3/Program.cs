using Prova.ConsoleApp3.ModuloCliente;
using Prova.ConsoleApp3.ModuloGarcom;
using System;
using System.Collections;

namespace Prova.ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                static void Main(string[] args)
                {
                    RepositorioCliente repositorioCliente = new RepositorioCliente(new ArrayList());

                    RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());

                    TelaCliente telaCliente = new  TelaCliente (repositorioCliente ,repositorioGarcom );
                                                                   
                    ApresentarMenu apresentarMenu = new ApresentarMenu();

                    


                    while (true)
                    {
                        

                        Console.WriteLine("Digite s para Sair");

                        string opcao = apresentarMenu.ApresentarOpcoes();

                        if (opcao == "s")
                            break;

                        if (opcao == "1")
                        {
                            string opcaoCliente = telaCliente.ApresentarMenu();

                            if (opcaoCliente == "1")
                                telaCliente.InserirNovoRegistro();
                            


                           

                            if (opcaoCliente == "2")
                                telaCliente.ExcluirRegistro();



                           
                            continue;
                        }
                    }
                }
            }
        }
    }
}

