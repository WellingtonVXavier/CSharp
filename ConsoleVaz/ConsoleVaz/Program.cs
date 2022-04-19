using System;

namespace ConsoleVaz
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco, total;

            Console.WriteLine("Escreva o codigo do produto:");
            codigo = int.Parse(Console.ReadLine());


            Console.WriteLine("Escreva a quantidade:");
            quantidade = int.Parse(Console.ReadLine());


            switch (codigo)
            {
                case 1:
                    preco = 5.50;
                    break;
                default:
                    preco = 0;
                    total = 0;
                    break;
            }

            total = quantidade * preco;
            Console.WriteLine($"   Total a pagar: {total}");

           

            Console.ReadLine();
        }
    }
}
