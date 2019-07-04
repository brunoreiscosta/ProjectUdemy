using System;

namespace ExercicioConicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com numero para saber se é par ou impar");

            int numero = int.Parse(Console.ReadLine());

            if (numero %2 == 0) {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
