using System;
using System.Globalization;

namespace introOO_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Funcionario fun = new Funcionario();
            
            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            fun.Salario = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Funcionário : " + fun);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CI);
            fun.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + fun);


        }
    }
}
