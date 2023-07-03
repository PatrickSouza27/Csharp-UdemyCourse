using System;


namespace CompararProduto
{
    class Program
    {
        static void Main()
        {
            List<Product> Products = new List<Product>();
            ServiceCalc EnviaLista = new ServiceCalc();
            Console.Write("Enter N: ");
            int qtd = int.Parse(Console.ReadLine());
            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Produto {0}", i + 1);
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço: ");
                double price = double.Parse(Console.ReadLine());
                Products.Add(new Product(nome, price));
            }
            Product Maxs = EnviaLista.Max(Products);
            Console.WriteLine("Most Expensive:");
            Console.WriteLine(Maxs);
        }
    }
}
