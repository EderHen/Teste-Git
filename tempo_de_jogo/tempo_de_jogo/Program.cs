using System;
using System.Globalization;

namespace tempo_de_jogo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hora inicial: ");
            int horaI = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            int horaF = int.Parse(Console.ReadLine());

            int total = 0;
            if(horaI < horaF)
            {
                total = horaF - horaI;
            }
            else
            {
                total = 24 - horaI + horaF;
            }

            Console.Write("O jogo durou " + total + " hora(S)");





        }
    }
}
