using System;

namespace ExerciciosCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu número, para saber se é negativo ou positivo.");

            int numero = int.Parse(Console.ReadLine());

            if (numero <= -1)
            {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NÃO NEGATIVO");
            }

        }
    }
}
