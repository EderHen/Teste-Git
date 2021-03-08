using System;
using System.Globalization;

namespace introductionOO_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            funcionarios f1 = new funcionarios();
            funcionarios f2 = new funcionarios();

            Console.WriteLine("Data of the first employee: ");
            Console.Write("Name: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Data of the second employee: ");
            Console.Write("Name: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine(), CI);

            double media = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CI));



        }
    }
}
