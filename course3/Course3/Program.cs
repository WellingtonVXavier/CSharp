using System;

namespace Course3
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            string[] banana = Console.ReadLine().Split(' ');
            string a = banana[0];
            string b = banana[1];
            string c = banana[2];


            Console.WriteLine("Você digitou: ", frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
