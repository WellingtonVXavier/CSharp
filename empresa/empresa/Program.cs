using System;
using System.Globalization;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("ENTRE COM OS DADOS DO FUNCIONÁRIO:");
            Console.WriteLine("________________________________________________________________________");

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Dados do funcionário: " + func);

            Console.WriteLine("-----------------------------------------");
            Console.Write("Deseja aumentar o salário em qual porcentagem?: ");
            double porncent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porncent);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Dados atualizados do funcionário: " + func);

            Console.ReadLine();
        }
    }
}
