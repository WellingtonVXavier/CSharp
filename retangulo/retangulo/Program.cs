using System;
using System.Globalization;

namespace retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Retangulo medidas = new Retangulo();
            
            Console.WriteLine("Entre a largula e altura do rentângulo: ");
            medidas.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            medidas.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Área = " + medidas.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + medidas.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + medidas.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
