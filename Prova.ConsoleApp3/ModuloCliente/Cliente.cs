using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3.ModuloCliente
{
    public  class Cliente : EntidadeBase
    {

       
        public string Id;
        public string Nome;
        public override ArrayList ValidarPedido => throw new NotImplementedException();

        public Cliente(string id, string nome)
        {
            Id = id;
            Nome = Nome;
        }



        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Cliente cliente = (Cliente)registroAtualizado;
           
            this.id = id;
            this.Nome = cliente.Nome;
        }
}
}
