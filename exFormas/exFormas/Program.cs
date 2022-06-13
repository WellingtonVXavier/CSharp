using System;
using System.Globalization;

namespace exFormas
{
    class Program
    {
        static void Main(string[] args)
        {
            double A6, B6, C6, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores1 = Console.ReadLine().Split(' ');

            A6 = double.Parse(valores1[0], CultureInfo.InvariantCulture);
            B6 = double.Parse(valores1[1], CultureInfo.InvariantCulture);
            C6 = double.Parse(valores1[2], CultureInfo.InvariantCulture);

            triangulo = A6 * C6 / 2.0;
            circulo = 3.14159 * C6 * C6;
            trapezio = (A6 + B6) / 2.0 * C6;
            quadrado = B6 * B6;
            retangulo = A6 * B6;

            Console.WriteLine("Triangulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
