using System;
using System.Globalization;

namespace RedoConstructThisEnca2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo C = CultureInfo.InvariantCulture;

            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ?");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), C);
                conta = new ContaBancaria(numeroconta, titular, depositoinicial);
            }
            else
            {
                conta = new ContaBancaria(numeroconta, titular);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), C);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), C);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
