using System;
using System.Globalization;

namespace classeFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario colaborador1, colaborador2, media;
            colaborador1 = new Funcionario();
            colaborador2 = new Funcionario();
            media = new Funcionario();

            Console.WriteLine("Dados do primerio funcionário:");
            Console.Write("Nome: ");
            colaborador1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            colaborador1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("------------------------------");

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            colaborador2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            colaborador2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media.salario = (colaborador1.salario + colaborador2.salario) / 2;

            Console.WriteLine("------------------------------");
            Console.WriteLine("Salário Médio: R$ " + media.salario.ToString("C2", CultureInfo.CurrentCulture)); 
            Console.ReadLine();
 
        }
    }
}
