using System;
using System.Globalization;

namespace Pagamento
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome;
            double vph, total;
            int hrt;

            Console.Write("NOME: ");
            nome = Console.ReadLine();
            Console.Write("Valor por Hora: ");
            vph = double.Parse(Console.ReadLine(), CI);
            Console.Write("Horas Trabalho: ");
            hrt = int.Parse(Console.ReadLine());

            total = vph * hrt;
            Console.Write("O pagamento para " + nome + " deve ser " + total.ToString("F2", CI));



        }
    }
}
