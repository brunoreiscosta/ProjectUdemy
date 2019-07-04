using System;

namespace ExercicioCondicional3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dois valores:");
            string[] valores = Console.ReadLine().Split(' ');

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS!!!!!!!!!!!!!!");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MULTIPLOS!!!!!!!!!!!!!");
            }
        }
    }
}
