using System;
using System.Globalization;


namespace RedoExercise05
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Funcionario func = new Funcionario();
            
            
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Funcionário: " + func);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CI);
            func.AumentarSalario(porc);

            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
