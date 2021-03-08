using System;

namespace senha_fixa
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.Write("Senha Invalida! Tente novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.Write("Acesso Permitido!");
        }
    }
}
