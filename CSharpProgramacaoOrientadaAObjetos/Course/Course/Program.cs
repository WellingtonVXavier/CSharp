using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            double preco1 = 2100.00;
            double preco2 = 650.00;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo o preço é R$"+ preco1.ToString("F2"));
            Console.WriteLine(produto2 + ", cujo o preço é R$" + preco2.ToString("F2"));

            Console.WriteLine();

            byte idade = 35;
            int codigo = 5290;
            char genero = 'M';
            string nome = "Wellington, ";

            Console.Write("Registro: ");
            Console.WriteLine(nome + idade + " anos de idade, " + "código " + codigo + ", genero: " + genero);

            Console.WriteLine();

            double preco3 = 2100.0;
            double preco4 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("Medidas: {0:f8}", medida);
            Console.WriteLine($"Medidas:  {medida:f3}");
            Console.WriteLine("Medidas: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("Medidas: {0:f8}", preco3);
            Console.WriteLine($"Medidas:  {preco3:f3}");
            Console.WriteLine("Medidas: " + preco3.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("Medidas: {0:f8}", preco4);
            Console.WriteLine($"Medidas:  {preco4:f3}");
            Console.WriteLine("Medidas: " + preco4.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
