using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3.ModuloFuncionario
{
    internal class Funcionario : EntidadeBase
    {
       public  string Nome;
        
        public Funcionario(string nome)
        {
            this.Nome = nome;
        }
        //public override ArrayList Validar()
        //{
        //    ArrayList erros = new ArrayList();

        //    if (string.IsNullOrEmpty(Nome.Trim()))
        //        erros.Add("O campo \"nome\" é obrigatório");
        //    return erros;
        //}
        public override ArrayList ValidarPedido => throw new NotImplementedException();
        
    public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Funcionario funcionarioAtualizado = (Funcionario)registroAtualizado;

            this.Nome = Nome;

                        
        }
        

    }
}
