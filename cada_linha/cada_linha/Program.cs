using System;

namespace cada_linha
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual a ordem da matriz? ");
            int m = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, m];

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("Elemento[" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Maior elemento de cada linha:");

            int maior = mat[0, 0];
            for(int i = 0; i < m; i++)
            {
               maior = mat[0, 0];

                for (int j = 0; j < m; j++)
                {
                    if(mat[i,j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
                
                Console.WriteLine(maior);
            }

        }
    }
}
