using System;
using ExemploFundamentos.Models;

namespace ExemploFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            
            pessoa1.Nome = "Luiz Pedro";
            pessoa1.Idade = 26;

            pessoa1.Apresentar();
        }
    }
}