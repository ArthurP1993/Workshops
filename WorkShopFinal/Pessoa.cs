using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopFinal
{
    public class Pessoa
    {
        private int Idade { get; set; }
        private string Nome { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Aniversario()
        {
            Idade++;
            //return Idade;
        }
        //Encapsulamento
        public int InformaIdade()
        {
            return Idade;
        }

        public string InformaNome()
        {
            return Nome;
        }

        virtual
        public string SeApresenta()
        {
            return $"Olá, sou {InformaNome()} e tenho {InformaIdade()} anos!";
        }
    }
}
