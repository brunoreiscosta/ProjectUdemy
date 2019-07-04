using System;
using System.Globalization;

namespace ExercicioCondicional6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o numero para saber seu intervalor");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0 || valor > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }

            else if (valor <= 25.00)
            {
                Console.WriteLine("Intervalo[0, 25]");
            }
            else if (valor <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (valor <= 100.00)
            {
                Console.WriteLine("Intervalor (75,100]");
            }
        }
    }
}
