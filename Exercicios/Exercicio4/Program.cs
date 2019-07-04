using System;
using System.Globalization;
namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o numero do funcionario");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o numero de horas trabalhadas");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor que recebe por hora trabalhada");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valor * horas;

            Console.WriteLine("Numero do Funcionario: " + numero);
            Console.WriteLine("Salario total do Funcionario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
