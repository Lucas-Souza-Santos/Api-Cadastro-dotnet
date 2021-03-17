using System;
using System.Collections.Generic;

namespace meu_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Conta minhaConta = new Conta();
            minhaConta.Nome = "Lucas";

            Console.WriteLine(minhaConta.Nome);
            
        }
    }
}
