using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 5 - Caracteres e textes");

            // char > caractere O char é um tipo de variavel que aceita a inserção de um caractere apenas.char letras = 'S';
            char Letra = 'a';
            Console.WriteLine(Letra);

            char valor = '6';
            Console.WriteLine(valor);

            valor = (Char) (valor + 1);
            Console.WriteLine(valor);

            string palavra = "alura Cursos de Tecnologia ";
            Console.WriteLine(palavra);

            palavra = palavra + 2022;
            Console.WriteLine(palavra);           




            Console.ReadLine();
        }
    }
}
