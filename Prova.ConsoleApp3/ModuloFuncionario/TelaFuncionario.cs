using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3.ModuloFuncionario
{
    internal class TelaFuncionario : TelaBase
    {
        public TelaFuncionario(RepositorioFuncionario repositorioFuncionario)
        {
            this.repositorioBase = repositorioFuncionario;
            nomeEntidade = "Funcionário";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            

            foreach (Funcionario funcionario in registros)
            {
                Console.WriteLine(funcionario.Nome);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            

            return new Funcionario(nome);
        }
    }

}