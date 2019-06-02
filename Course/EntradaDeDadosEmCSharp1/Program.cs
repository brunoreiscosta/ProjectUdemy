using System;

namespace EntradaDeDadosEmCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine(); // ReadLine, é um comando que captura o que o usuario digita com teclado
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            string[] v = Console.ReadLine().Split(' ');//split é uma forma de regex dentro de um array
            string a = v[0];
            string b = v[1];
            string c = v[2];


            Console.WriteLine("você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
