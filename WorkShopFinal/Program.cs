using System;
using System.Collections.Generic;

namespace WorkShopFinal
{
    class Program
    {
        public static Pessoa JoaoZinho;

        static void Main(string[] args)
        {
            if (JoaoZinho is null)
                JoaoZinho = new Pessoa("JoãoZinho da Silva", 47);
            
            //Console.WriteLine(JoaoZinho.SeApresenta());

            Aluno maria = new Aluno("Maria Souza", 16, "3º B");

            //Console.WriteLine(maria.SeApresenta());
            Professor girafales = new Professor(new List<string>(), 44, "Professor Girafales");

            List<Pessoa> galera = new List<Pessoa>()
            {
                JoaoZinho,
                maria,
                girafales
            };

            foreach (Pessoa pessoa in galera)
            {
                Console.WriteLine(pessoa.SeApresenta());
            }
            Console.ReadKey();
        }
    }
}
