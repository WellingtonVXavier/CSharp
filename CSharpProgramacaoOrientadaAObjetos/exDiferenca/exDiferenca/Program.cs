using System;

namespace exDiferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            int A3, B3, C3, D3, dif;

            A3 = int.Parse(Console.ReadLine());
            B3 = int.Parse(Console.ReadLine());
            C3 = int.Parse(Console.ReadLine());
            D3 = int.Parse(Console.ReadLine());

            dif = A3 * B3 - C3 * D3;

            Console.WriteLine("Diferença = " + dif);
        }
    }
}
