﻿using System;

namespace Soma_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores vai ter cada vetor? ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];

            Console.WriteLine("Digite os valores do vetor A:");
            for (int i = 0; i < n; i++)
            {               
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os valores do vetor B:");
            for (int i = 0; i < n; i++)
            {               
                b[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vetor Resultante:");
            for(int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i];
                Console.WriteLine(c[i]);
            }






        }
    }
}
