using System;
using System.Globalization;

namespace exRaioPi
{
    class Program
    {
        static void Main(string[] args)
        {
            double Raio, A2, pi = 3.14159;

            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A2 = pi * Raio * Raio;

            Console.WriteLine("A = " + A2.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
