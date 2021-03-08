using System;
using System.Globalization;
using System.Text;

namespace RedoConstructThisEnca2
{
    class ContaBancaria
    {

        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria (int conta, string titular, double saldo) : this(conta, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        
        public void Saque(double saque)
        {
            Saldo -= saque + 5;
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
