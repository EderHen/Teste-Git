using System;
using System.Collections.Generic;

namespace HashSetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
           
            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            A.ExceptWith(B);

            foreach (int obj in A)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------------");
            foreach(int obj2 in B)
            {
                Console.WriteLine(obj2);
            }

            Console.WriteLine("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine(N + " Pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine(N + " Não pertence ao conjunto B");
            }

            Console.WriteLine("--------------------");
            B.Remove(4);

          

        }
    }
}
