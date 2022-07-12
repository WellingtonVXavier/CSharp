using System;
using System.Globalization;

namespace estoqueLoja
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", " 
                + Preco.ToString("C2", CultureInfo.CurrentCulture) 
                + ", " 
                + Quantidade 
                + " Unidades, Total: " 
                + ValorTotalEmEstoque().ToString("C2", CultureInfo.CurrentCulture);
        }
    }
}
