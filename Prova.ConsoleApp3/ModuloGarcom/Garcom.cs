using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string Cliente;
        public string Id;

        public override ArrayList ValidarPedido => throw new NotImplementedException();

        public Garcom(string id)
        {
            Id = id;
        }

       

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom garcom = (Garcom)registroAtualizado;
            this.Cliente = Cliente;
            this.id = id;
        }              
        
    }
}
