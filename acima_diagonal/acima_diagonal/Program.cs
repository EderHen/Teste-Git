using System;

namespace acima_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual a ordem da matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int somaD = 0;

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());

                    if(i < j)
                    {
                        somaD = somaD + mat[i, j];
                    }

                }
            }

            Console.Write("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + somaD);

        }
    }
}
