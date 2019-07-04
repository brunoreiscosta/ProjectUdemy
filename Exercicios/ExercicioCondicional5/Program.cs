﻿using System;
using System.Globalization;

namespace ExercicioCondicional5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o código do item e sua quantidade(separado por espaço)");

            string[] valores = Console.ReadLine().Split(' ');

            double codigo = double.Parse(valores[0]);
            double quantidade = double.Parse(valores[1]);

            double total;

            if (codigo == 1)
            {

                total = quantidade * 4.0;

            }

            else if (codigo == 2)
            {

                total = quantidade * 4.5;

            }

            else if (codigo == 3)
            {

                total = quantidade * 5.0;

            }

            else if (codigo == 4)
            {

                total = quantidade * 2.0;

            }

            else
            {

                total = quantidade * 1.5;

            }



            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
