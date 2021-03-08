using System;
using System.Globalization;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            char escala = char.Parse(Console.ReadLine());

            double fah, cel;

            if(escala == 'F')
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                fah = double.Parse(Console.ReadLine(), CI);
                cel = 5.0 / 9.0 * (fah - 32.0);
                Console.Write("Temperatura Equivalente em Celsius: " + cel.ToString("F2", CI));
            }
            else
            {
                Console.Write("Digite a temperatura em Celsius: ");
                cel = double.Parse(Console.ReadLine(), CI);
                fah = cel * 9.0 / 5.0 + 32.0;
                Console.Write("Temperatura equivalente em Fahrenheit: " + fah.ToString("F2", CI));
            }


        }
    }
}
