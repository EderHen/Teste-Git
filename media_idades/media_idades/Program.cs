using System;
using System.Globalization;
namespace media_idades
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite as idades:");
            int idades = int.Parse(Console.ReadLine());

            int soma = 0;
            int qtd = 0;
            double media;

            if (idades < 0)
            {
                Console.Write("IMPOSSIVEL CALCULAR");
            }


            else
            {
                while (idades > 0)
                {
                    soma = soma + idades;
                    qtd++;
                    idades = int.Parse(Console.ReadLine());
                }
                media = (double)soma / (double)qtd;
                Console.Write("MEDIA = " + media.ToString("F2", CI));

            }
               

        }
    }
}
