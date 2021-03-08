using System;
using System.Globalization;

namespace matriz_geral
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];
            double somaP = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = double.Parse(Console.ReadLine(), CI);

                    if (mat[i, j] > 0)
                    {
                        somaP = somaP + mat[i, j];
                    }

                }
            }
            Console.WriteLine("\nSOMA DOS POSITIVOS: " + somaP.ToString("F1", CI));

            Console.Write("\n\nEscolha um linha: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Linha Escolhida: ");
            for (int i = linha; i <= linha; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j].ToString("F1", CI) + " ");
                }
            }


            Console.Write("\n\nEscolha uma coluna: ");
            int coluna = int.Parse(Console.ReadLine());
            Console.Write("Coluna Escolhida: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = coluna; j <= coluna; j++)
                {
                    Console.Write(mat[i, j].ToString("F1", CI) + " ");
                }
            }

            Console.Write("\n\nDiagonal Principal: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j].ToString("F1", CI) + " ");
                    }
                }
            }

            Console.WriteLine("\n\nMATRIZ ALTERADA: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        mat[i, j] = mat[i, j] * mat[i, j];
                    }
                    Console.Write(mat[i, j].ToString("F1",CI) + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
