using System;

namespace RedoFixationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] alunosinfo = new Quartos[9];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #{0}:", (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                alunosinfo[quarto] = new Quartos(nome, email);

            }

            Console.WriteLine("\nQuartos ocupados:");
            for(int i = 0; i <= 9; i++)
            {
                if(alunosinfo[i] != null)
                {
                    Console.WriteLine(i + ": " + alunosinfo[i]);
                }
            }
            
            
        }
    }
}
