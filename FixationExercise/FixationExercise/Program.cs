using System;

namespace FixationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de Linhas e Colunas da matriz:");
            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);
            

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] split = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(split[j]);
                }

            }
            Console.WriteLine("Digite um numero da matriz para saber sua posição e seus vizinhos:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position = {0},{1}:", i, j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}
