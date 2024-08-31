using System;
using ExemploFundamentos.Common.Models;

namespace ExemploFundamentos;

class Program
{
    public static void Main(String[] args)
    {
        int[] arrayInteiros = new int[3];

        arrayInteiros[0] = 72;
        arrayInteiros[1] = 64;
        arrayInteiros[2] = 50;

        foreach (int inteiro in arrayInteiros)
        {
            Console.WriteLine(inteiro);
        }
        
        // for (int i = 0; i < arrayInteiros.Length; i++)
        // {
        //     Console.WriteLine(arrayInteiros[i]);
        // }

        // Pessoa pessoa1 = new Pessoa();
        //
        // pessoa1.Nome = "Luiz Pedro";
        // pessoa1.Idade = 26;
        // pessoa1.Forca = 200f;
        // for (var i = 0; i < 3; i++) { pessoa1.AumentaForca(); }
        //  pessoa1.Apresentar();
    }
}