using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3.ModuloPedido
{
    internal class Pedido : EntidadeBase
    {
        
        public string Garcom;
        public string Cliente;
        public string IdMesa;

        public bool EstaAberto;

        public override ArrayList ValidarPedido => throw new NotImplementedException();

        public void Fechar()
        {
            if (EstaAberto)
            {
                EstaAberto = false;
               
            }
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Pedido pedidoAtt = (Pedido)registroAtualizado;


            Cliente = pedidoAtt.Cliente;
            Garcom = pedidoAtt.Garcom;
            IdMesa = pedidoAtt.IdMesa;

        }
    }
}
