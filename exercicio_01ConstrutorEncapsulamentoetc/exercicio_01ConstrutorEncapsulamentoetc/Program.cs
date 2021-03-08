using System;
using System.Globalization;

namespace exercicio_01ConstrutorEncapsulamentoetc
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            
            ContaBancaria cliente = new ContaBancaria(conta, nome, 0);
            
            Console.Write("Haverá deposito inicial? ");
            char simounao = char.Parse(Console.ReadLine());
            cliente.Inicial(simounao);

            if (cliente.Inicial(simounao))
            {
                Console.Write("Entre o valor de depósito incial: ");
                double deposi = double.Parse(Console.ReadLine(), CI);
                cliente.DepositoInicial(deposi);

            }


            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(cliente);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double depositar = double.Parse(Console.ReadLine(), CI);
            cliente.Depositar(depositar);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);
            Console.WriteLine();


            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CI);
            cliente.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);


            

           






        }
    }
}
