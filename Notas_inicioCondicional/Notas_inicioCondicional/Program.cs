using System;
using System.Globalization;

namespace Notas_inicioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine(), CI);

            double media = nota1 + nota2;

            Console.WriteLine("Nota FINAL = " + media.ToString("F1", CI));

            if(media < 60.00)
            {
                Console.Write("REPROVADO");
            }
        



        }
    }
}
