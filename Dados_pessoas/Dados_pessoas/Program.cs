using System;
using System.Globalization;

namespace Dados_pessoas
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantas pessoas serao digitadas? ");
            int n = int.Parse(Console.ReadLine());

            char[] genero = new char[n];
            double[] altura = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Altura da " + (i + 1) + "a pessoa: ");
                altura[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Genero da " + (i + 1) + "a pessoa: ");
                genero[i] = char.Parse(Console.ReadLine());
            }

            double maior = altura[0], menor = altura[0];
            for(int i = 0; i < n; i++)
            {
                if(altura[i] > maior)
                {
                    maior = altura[i];
                }
                if(altura[i] < menor)
                {
                    menor = altura[i];
                }

            }
            double soma = 0, media;
            int qtdF = 0, qtdM = 0;
            for(int i = 0; i < n; i++)
            {
                if(genero[i] == 'F')
                {
                    qtdF++;
                    soma = soma + altura[i];
                }
                else
                {
                    qtdM++;
                }
            }
            media = soma / qtdF;
            Console.WriteLine("Menor altura = " + menor.ToString("F2", CI));
            Console.WriteLine("Maior altura = " + maior.ToString("F2", CI));
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CI));
            Console.WriteLine("Numero de homens = " + qtdM);







        }
    }
}
