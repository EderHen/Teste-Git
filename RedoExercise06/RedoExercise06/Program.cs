using System;
using System.Globalization;

namespace RedoExercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo C = CultureInfo.InvariantCulture;

            Aluno aluno = new Aluno();
            
            
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), C);
            aluno.Nota2 = double.Parse(Console.ReadLine(), C);
            aluno.Nota3 = double.Parse(Console.ReadLine(), C);

            Console.WriteLine("Nota FInal = {0}", aluno.NotaFInal().ToString("F2", C));
            if(aluno.Reprovado())
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram {0} Pontos", aluno.NotaRestante().ToString("F2", C));
            }
            else
            {
                Console.WriteLine("Aprovado");
            }

        }
    }
}
