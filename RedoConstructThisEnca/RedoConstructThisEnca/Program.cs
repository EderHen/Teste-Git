using System;
using System.Globalization;

namespace RedoConstructThisEnca
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo C = CultureInfo.InvariantCulture;

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial (S/N)? ");
            char VaiTerDepIni = char.Parse(Console.ReadLine());

            if (VaiTerDepIni == 's' || VaiTerDepIni == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), C);
                conta = new ContaBancaria(numeroconta, nome, depositoinicial);

            }
            else
            {
                conta = new ContaBancaria(numeroconta, nome);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), C);
            conta.ValorDeposito(deposito);

            Console.WriteLine("Dados da conta atulizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), C);
            conta.ValorSaque(saque);

            Console.WriteLine("Dados atualizados da conta:");
            Console.WriteLine(conta);
        }
    }
}
