using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            float pontoFlutuante = 3.14f;  //aqui!
            Console.WriteLine(pontoFlutuante);

            double salario = 1270.50;
            int valor = (int)salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);

            int idade = 30;
            Console.WriteLine("A idade de Marcos é " + idade + "!");  //compila

            double idade1 = 30.0;
            Console.WriteLine("A idade de Marcos é " + (int)idade1 + "!");  //compila, int dentro de double é possivel


            idade = 20;
            Console.WriteLine("A idade de Marcos é 30!");  //compila    


            Console.WriteLine("Execução finalizada, tecle enter para sair.");
            Console.ReadLine();

           

        }

    }
}