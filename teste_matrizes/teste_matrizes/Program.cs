using System;
using System.Globalization;

namespace teste_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j;

            Console.WriteLine("Quantas linhas vai ter a matriz? ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas colunas vai ter a matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) {
                    Console.WriteLine("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine();
            Console.WriteLine("Matriz Digitada:");
            for (i = 0; i < m; i++) { 
                for(j = 0; j < n; j++) {
                    Console.Write(mat[i, j] + " ");

                }
                Console.WriteLine();
            }
            
        }
    }
}
