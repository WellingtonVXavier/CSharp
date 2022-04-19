using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - condicionais2");

            int numero1 = 6;
            bool par1 = true;
            string valor1;

            if (par1 == true)
            {
                valor1 = "par";               
            }
            else
            {
                valor1 = "impar";
               
            }

            if (numero1 >= 6 || par1 == true)
            {
                Console.WriteLine("6");
                Console.WriteLine(valor1);
            }
            else
            {
                Console.WriteLine("3");
            }

            Console.ReadLine();
        }
    }
}
