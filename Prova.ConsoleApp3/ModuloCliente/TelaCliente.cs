using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3.ModuloCliente
{
    internal class TelaCliente : TelaBase
    {

        public TelaCliente(RepositorioCliente repositorioPaciente, ModuloGarcom.RepositorioGarcom repositorioGarcom)
        {
            this.repositorioBase = repositorioPaciente;
            nomeEntidade = "Cliente";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Cliente cliente in registros)
            {
                Console.WriteLine(cliente.id);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite Numero da Mesa : ");
            string id = Console.ReadLine();

            Console.Write("Digite Nome Do Cliente : ");
            string nome = Console.ReadLine();

            Cliente cliente = new Cliente(id,nome);

            return cliente;
        }
    }
}
