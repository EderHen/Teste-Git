using System;
using System.Collections.Generic;

namespace TestHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os codigos dos alunos do curso A");
            for(int i = 0; i < a1; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso A possui quantos alunos? ");
            int a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os codigos dos alunos do curso B");
            for (int i = 0; i < a2; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso A possui quantos alunos? ");
            int a3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os codigos dos alunos do curso C");
            for (int i = 0; i < a3; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> total = new HashSet<int>();
            total.UnionWith(A);
            total.UnionWith(B);
            total.UnionWith(C);
            Console.WriteLine("Total de ALunos: " + total.Count);

        }
    }
}
