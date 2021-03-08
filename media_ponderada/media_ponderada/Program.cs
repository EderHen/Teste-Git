using System;
using System.Globalization;

namespace media_ponderada
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos casos voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            double x1, x2, x3, media;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite tres numeros: ");
                x1 = double.Parse(Console.ReadLine(), CI);
                x2 = double.Parse(Console.ReadLine(), CI);
                x3 = double.Parse(Console.ReadLine(), CI);

                media = (x1 * 2.0 + x2 * 3.0 + x3 * 5.0) / 10.0;
                Console.WriteLine("MEDIA = " + media.ToString("F1", CI));

            }


        }
    }
}
