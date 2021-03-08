using System;

namespace ifelse_ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o horario de inicio e fim do jogo:");
            string[] horarios = Console.ReadLine().Split(' ');
            int horainicial = int.Parse(horarios[0]);
            int horafinal = int.Parse(horarios[1]);

            int duracao;
            if (horainicial < horafinal)
            {
                duracao = horafinal - horainicial;
            }
            else
            {
                duracao = 24 - horainicial + horafinal;
            }
            Console.WriteLine($"O Jogo durou {duracao} Hora(s)");












        }
    }
}
