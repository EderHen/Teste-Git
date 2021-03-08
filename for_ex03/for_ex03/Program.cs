using System;
using System.Globalization;

namespace for_ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.WriteLine("Digite o numero de casos que vira a seguir");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double x1 = double.Parse(valores[0], CI);
                double x2 = double.Parse(valores[1], CI);
                double x3 = double.Parse(valores[2], CI);

                double media = (x1 * 2.0 + x2 * 3.0 + x3 * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CI));




            }


        }
    }
}
