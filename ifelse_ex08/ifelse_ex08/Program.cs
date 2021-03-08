using System;
using System.Globalization;

namespace ifelse_ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.WriteLine("Digite o valor do seu salário");
            double salario = double.Parse(Console.ReadLine(), CI);

            double imposto;
            if(salario > 2000.00 && salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
                Console.WriteLine(imposto.ToString("F2", CI));
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                imposto = ((salario - 3000.00) * 0.18) + 80;
                Console.WriteLine(imposto.ToString("F2", CI));
            }
            else if(salario > 4500.00)
            {
                imposto = ((salario - 4500.00) *  0.28) + 350;
                Console.WriteLine(imposto.ToString("F2", CI));
            }
            else
            {
                Console.WriteLine("Isento!");
            }


        }
    }
}
