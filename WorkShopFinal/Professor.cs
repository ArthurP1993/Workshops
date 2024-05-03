using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopFinal
{
    public class Professor : Pessoa
    {

        public List<string> TurmaLista { get; set; }

        public Professor(List<string> turmas, int idade, string nome) 
            : base (nome, idade)
        {
            TurmaLista = turmas;
        }
    }
}
