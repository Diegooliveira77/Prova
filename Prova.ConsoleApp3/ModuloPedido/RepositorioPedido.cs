using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3.ModuloPedido
{
    internal class RepositorioPedido : RepositorioBase
    {    
        public RepositorioPedido(ArrayList listaEmprestimo)
        {
            this.listaRegistros = listaEmprestimo;
        }

        public override Pedido SelecionarPorId(int id)
        {
            return (Pedido)base.SelecionarPorId(id);
        }
        public ArrayList SeleionarEmprestimosEmAberto()
        {
            ArrayList emprestimoEmAberto = new ArrayList();

            foreach (Pedido ped in listaRegistros)
            {
                if (ped.EstaAberto)
                    emprestimoEmAberto.Add(ped);

            }
            return emprestimoEmAberto;
        }

        public ArrayList SelecionarEmprestimosEmAbertoNoDia(DateTime data)
        {
            ArrayList pedidoEmAberto = new ArrayList();

            foreach (Pedido e in listaRegistros)
            {
                if (e.EstaAberto )
                    pedidoEmAberto.Add(e);
            }
            return pedidoEmAberto;

        }
      
        }
    }

