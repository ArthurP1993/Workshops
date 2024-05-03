using System;

namespace WorkShopFinal
{
    class Program
    {
        public static Pessoa JoaoZinho;

        static void Main(string[] args)
        {
            if (JoaoZinho is null)
                JoaoZinho = new Pessoa("JoãoZinho da Silva", 47);
            
            Console.WriteLine(JoaoZinho.SeApresenta());

            Console.ReadKey();
        }
    }
}
