using System;

namespace quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores de X e Y: ");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y= int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Quadrante 1"); 
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Quadrante 2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Quadrante 3");
                }
                else
                {
                    Console.WriteLine("Quadrante 4");
                }

                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}
