using System;

namespace ArrayBi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a ordem da Matriz:");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }


            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                    Console.Write(mat[i, i] + " ");
            }


            int count = 0;
            foreach (int obj in mat)
            {
                if (obj < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("\nNegative Numbers = " + count);



        }
    }
}
