using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com 4 numeros");

            int a, b, c, d, soma;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            soma = (a * b) - (c * d);

            Console.WriteLine(soma);
        }
    }
}
