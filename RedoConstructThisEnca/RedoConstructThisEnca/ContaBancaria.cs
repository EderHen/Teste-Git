using System;
using System.Globalization;
using System.Text;

namespace RedoConstructThisEnca
{
    class ContaBancaria
    {

        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroconta, string nome)
        {
            NumeroConta = numeroconta;
            Nome = nome;
        }

        public ContaBancaria(int numeroconta, string nome, double saldo) : this(numeroconta, nome)
        {
            Saldo = saldo;
        }

        public void ValorDeposito(double deposito)
        {
            Saldo += deposito;
        }

        public void ValorSaque(double saque)
        {
            Saldo -= saque + 5;
        }

        public override string ToString()
        {
            return NumeroConta + " Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }


}
