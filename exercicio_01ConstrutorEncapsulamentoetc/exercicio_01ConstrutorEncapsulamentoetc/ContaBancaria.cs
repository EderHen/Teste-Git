using System;
using System.Globalization;
using System.Text;

namespace exercicio_01ConstrutorEncapsulamentoetc
{
    class ContaBancaria
    {
        public int Conta { get; private set; } // Atributos do objeto
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string nome, double saldo)
        {
            Conta = conta;
            Nome = nome;
            Saldo = saldo;
        }

        public bool Inicial(char simnao)
        {
            if (simnao == 's' || simnao == 'S')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DepositoInicial(double deposi)
        {
            Saldo += deposi;
        }

        public void Depositar(double deposito)
        {
           Saldo += deposito;
        }

        public void Sacar(double saque)
        {
          Saldo -= saque + 5;
        }


        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
