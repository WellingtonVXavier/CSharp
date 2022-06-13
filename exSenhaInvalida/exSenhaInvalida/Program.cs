using System;

namespace exSenhaInvalida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seua Senha: ");
            int senha = int.Parse(Console.ReadLine());
            int cont = 0;

            
            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite sua Senha: ");
                senha = int.Parse(Console.ReadLine());

                cont++;
            if (cont == 4)
            {
                Console.WriteLine("Acesso Negado!");               
            }

            }

            Console.WriteLine("Acesso Permitido!");
        }
    }
}
