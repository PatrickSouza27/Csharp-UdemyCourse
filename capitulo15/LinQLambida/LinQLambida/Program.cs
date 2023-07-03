using LinQLambida.entities;
using System;


namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Tv", 900));
            products.Add(new Product("Notebook", 1200));
            products.Add(new Product("Tablete", 900));
            try
            {
                products.Sort();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach(Product p in products)
            {
                Console.WriteLine(p);
            }
        }
        static int CompareProducts(Product p1, Product p2)
        {

        }
    }
}
