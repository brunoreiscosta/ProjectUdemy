using System;

namespace ExercicioWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite a Senha Novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
