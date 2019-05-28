using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 24;
            double saldo = 10.24525;
            string nome = "Maria";
            string divisor = "-----------------------------------------------------------------";


            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2")); //ToString controla as casas decimais. F2 -> 2 casas F3-> 3 casas
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // InvariantCulture tira qualquer formatação especifica.
            Console.WriteLine(divisor);

            Console.WriteLine("{0} tem {1} anos e tem saldo = {2:F2} reais", nome, idade, saldo); //Placeholder
            Console.WriteLine($"{nome} tem {idade} anos e saldo igual a {saldo:F2} reais"); // Interpolação.
            Console.WriteLine(nome + " tem " + idade + " anos e saldo igual a "+ saldo.ToString("F2") + " reais "); //Concatenação

        }
    }
}
