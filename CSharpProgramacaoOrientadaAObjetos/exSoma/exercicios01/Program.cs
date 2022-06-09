using System;
using System.Globalization;

namespace exercicios01
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, soma;

            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            soma = valor1 + valor2;

            Console.WriteLine("Soma = " + soma);



        }
    }
}
