using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.ConsoleApp3.ModuloGarcom
{
    public class TelaGarcom : TelaBase
    {
        public TelaGarcom()
        {
            this.repositorioBase = repositorioBase;
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Garcom garcom in registros)
            {
                Console.WriteLine(garcom.id);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite Numero da Mesa : ");
            string id = Console.ReadLine();                              

            Garcom garcom = new Garcom(id );

            return garcom;
        }
    }

       
    }


