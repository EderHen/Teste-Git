using System;
using System.Globalization;
namespace Terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, comprimento, vm2, area, preco;

            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor do metro quadra do: ");
            vm2 = double.Parse(Console.ReadLine(), CI);

            area = largura * comprimento;
            preco = vm2 * area;
            Console.WriteLine("Area do terreno = " + area.ToString("F2", CI));
            Console.WriteLine("Preco do terreno = " + preco.ToString("F2", CI));



        }
    }
}
