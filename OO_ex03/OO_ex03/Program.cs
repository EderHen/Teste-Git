using System;
using System.Globalization;

namespace OO_ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            aluno informacoes = new aluno();

            Console.Write("Nome do aluno");
            informacoes.Nome = Console.ReadLine();
            Console.WriteLine("Digite as notas do aluno:");
            informacoes.Nota1 = double.Parse(Console.ReadLine(), CI);
            informacoes.Nota2 = double.Parse(Console.ReadLine(), CI);
            informacoes.Nota3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("NO FINAL = " + informacoes.NotaFInal().ToString("F2", CI));
            if(informacoes.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + informacoes.NotaRestante().ToString("F2", CI) + " PONTOS" );
            }
        }
    }
}