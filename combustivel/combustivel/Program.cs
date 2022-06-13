using System;

namespace combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Informe um código (1, 2, 3) ou 4 para finalizar o abastecimento: ");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    gasolina = gasolina + 1;
                }
                else if (codigo == 2)
                {
                    alcool = alcool + 1;
                }
                else if (codigo == 3)
                {
                    diesel = diesel + 1;
                }

                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
