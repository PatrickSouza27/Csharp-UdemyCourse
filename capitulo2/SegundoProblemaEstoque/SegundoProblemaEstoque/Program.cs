using System;
using System.Globalization;
using SegundoProblemaEstoque;


namespace SegundoProblema
{
    class Program
    {
        static void Main()
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os Dados do Produto: ");
            Console.Write("Nome :");
            p.Nome = Console.ReadLine();
            Console.Write("Digite o Preço Do Produto :");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a Quantidade :");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informações Produto: {0}", p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de Produto deseja adicionar: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);
            Console.WriteLine("Dados atualizados: {0}", p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de Produto deseja remover:");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine("Dados atualizados: {0}", p);
        }
    }
}