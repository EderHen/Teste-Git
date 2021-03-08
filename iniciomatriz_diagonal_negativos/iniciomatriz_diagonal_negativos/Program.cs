using System;

namespace iniciomatriz_diagonal_negativos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual a ordem da matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
            for(int j = 0; j < n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]:");
                    mat[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Diagonal Principal:");
            for(int i = 0; i < n; i++)
            {
            Console.Write(mat[i, i]+ "  ");
            }

            int qtd = 0;
            Console.WriteLine("\nQuantidade de negativos:");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                      qtd++;
                        
                    }
                }
                
            }
            Console.WriteLine(qtd);
        }
    }
}
