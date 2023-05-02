using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3.ModuloGarcom
{
    public class RepositorioGarcom :RepositorioBase
    {
        public RepositorioGarcom(ArrayList listaGarcom)
        {
            this.listaRegistros = listaRegistros;
        }

        public override Garcom SelecionarPorId(int id)
        {
            return (Garcom)base.SelecionarPorId(id);
        }
    }
}

