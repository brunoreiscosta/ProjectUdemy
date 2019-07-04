using System;

namespace ExercicioCondicional4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a hora inicial e a hora final do jogo");

            string [] valores = Console.ReadLine().Split(' ');
            //Usamos split para dizer quando pegar a informação com algum sepador
            //No caso acima a array valores está recebendo tudo que o usuario digitar e os separando por espaços.
            //E separa as informações por indices, como mostrado abaixo, a variavel está recebendo o valor digitado
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);
            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
