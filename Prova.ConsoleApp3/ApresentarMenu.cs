using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3
{
    internal class ApresentarMenu
    {
         
        public string ApresentarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Opções \n");

            Console.WriteLine("Digite 1 para Realizar Pedido");
            Console.WriteLine("Digite 2 Excluir Pedido");
                                             
            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
