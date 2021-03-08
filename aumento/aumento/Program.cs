using System;
using System.Globalization;

namespace aumento
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o salario da pessoa: ");
            double salario = double.Parse(Console.ReadLine(), CI);

            double aumento = 0, salarioN = 0, porc = 0;
            if (salario <= 1000.00)
            {
                porc = 20;
                aumento = salario * porc / 100;
                salarioN = salario + aumento;
            }
            else if (salario <= 3000.00)
            {
                porc = 15;
                aumento = salario * porc / 100;
                salarioN = salario + aumento;
            }
            else if (salario <= 8000.00)
            {
                porc = 10;
                aumento = salario * porc / 100;
                salarioN = salario + aumento;
            }
            else if (salario > 8000.00)
            {
                porc = 5;
                aumento = salario * porc / 100;
                salarioN = salario + aumento;
            }

            Console.WriteLine("Novo Salario = " + salarioN.ToString("F2", CI));
            Console.WriteLine("Aumento = " + aumento.ToString("F2", CI));
            Console.WriteLine("Porcentagem = " + porc + "%");


        }
    }
}
