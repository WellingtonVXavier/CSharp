using System;
using System.Globalization;

namespace exHorario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double salario, valorHora;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("Número = " + numero);
            Console.WriteLine("Salário = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
