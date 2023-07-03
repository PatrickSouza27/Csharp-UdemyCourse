using System;
using System.Globalization;

namespace SegundoProblemaEstoque
{
    internal class Produto
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;
        public double ValorTotalEsqtoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProduto(int quantitade)
        {
            Quantidade = Quantidade + quantitade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString()
        {
            return ($"{Nome}, ${Preco}, {Quantidade} Unidades, Total: ${ValorTotalEsqtoque().ToString("f2", CultureInfo.InvariantCulture)}"); 
        }
    }
}
