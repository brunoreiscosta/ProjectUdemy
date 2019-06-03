using System;
using System.Globalization;

namespace ExercicioFixacaoEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hoje aprenderemos a usar o comando de  conversão de tipos utilizando o comando
             .Parse. Este comando tem de todas as formas por exemplo abaixo estamos usando o double.Parse*/
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            string quartos = Console.ReadLine();

            Console.WriteLine("Entre com o preço do produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
