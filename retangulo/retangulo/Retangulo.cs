using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace retangulo
{
    class Retangulo
    {
        public double largura;
        public double altura;


        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return (largura + altura) * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }

        public override string ToString()
        {
            return "Área = " + Area().ToString("F2", CultureInfo.InvariantCulture);
            return " Perímetro = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture);
            return " Diagonal = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
