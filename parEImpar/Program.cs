using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parEImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;


            Console.WriteLine("CALCULADORA");
            Console.WriteLine("CALCULE:");

            valor = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(valor);

            valor = valor % 2;

            if(valor == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }       

                                 
             Console.ReadLine();
        }
    }
}
