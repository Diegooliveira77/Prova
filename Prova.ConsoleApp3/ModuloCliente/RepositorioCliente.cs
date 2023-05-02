using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3.ModuloCliente
{
    internal class RepositorioCliente : RepositorioBase
    {
        public RepositorioCliente(ArrayList listaGarcom)
        {
            this.listaRegistros = listaRegistros;
        }

        public override Cliente SelecionarPorId(int id)
        {
            return (Cliente)base.SelecionarPorId(id);
        }
    }
}

