using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopFinal
{
    public class Aluno : Pessoa
    {
        private string Turma { get; set; }
        public Aluno(string nome, int idade, string turma) : base (nome, idade)
        {
            Turma = turma;
        }

        override
        public string SeApresenta()
        {
            return $"{base.SeApresenta()} da Turma {Turma}";
        }
    }
}
