using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {

        static double Soma(double a, double b)
        {
            return a + b;
        }

        static double Subtracao(double a, double b)
        {
            return a - b; //Correção Subtração
        }

        static double Multiplicacao(double a, double b)
        {
            return a * b;
        }
        static double Divisao(double a, double b)
        {
            return a / b;
        }
             

        static void Main(string[] args)
        {

            double n1, n2, res = 0;
            string operacao;
            bool hasErro = false;

            Console.WriteLine("Calculadora");
            Console.WriteLine("Numero 1: ");
            double.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine("Numero 2: ");
            double.TryParse(Console.ReadLine(), out n2);

            Console.WriteLine("Qual operação deseja efetuar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");


            operacao = Console.ReadLine();
            //int.TryParse(Console.ReadLine(), out operacao);

            switch (operacao)
            {
                case "1":
                    //res = Soma(n1, n2);
                    res = n1 + n2;
                    break;
                case "2":
                    //res = Subtracao(n1, n2);
                    res = n1 + n2;
                    break;
                case "3":
                    //res = Multiplicacao(n1, n2);
                    res = n1 + n2;
                    break;
                case "4":
                    //res = Divisao(n1, n2);
                    res = n1 + n2;
                    break;

                default:
                    hasErro = true;                   
                    break;
            }

            if (hasErro)
            {
                Console.WriteLine("Resultado Invalido");
            }
            else
            {
                Console.WriteLine($"O resultado da operação é: {res}");
                
            }

            Console.ReadKey();
        }
    }
}
