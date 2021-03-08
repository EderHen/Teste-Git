using System;
namespace Mais_velho
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Write("Quantas pessoas voce vai digitar? ");
        int n = int.Parse(Console.ReadLine());

        string[] nome = new string[n];
        int[] idade = new int[n];

        int maior = idade[0];
        int posmaior = 0;
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Dados da " + (i + 1) + " pessoa:");
            Console.Write("Nome: ");
            nome[i] = Console.ReadLine();
            Console.Write("Idade: ");
            idade[i] = int.Parse(Console.ReadLine());

            if(idade[i] > maior)
            {
                    maior = idade[i];
                    posmaior = i;
            }
        }
        Console.Write("Pessoa mais velha: " + nome[posmaior]);

        }
    }
}
