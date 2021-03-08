using System;
using System.Globalization;

namespace RedoExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();
            
            
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Name: ");
            f1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            f1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Name: ");
            f2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            f2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medio = (f1.Salary + f2.Salary) / 2;

            Console.WriteLine("Salário médio = {0}", medio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
