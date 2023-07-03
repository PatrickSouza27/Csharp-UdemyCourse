using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(900, "TV"));
            products.Add(new Product(90, "radio"));
            products.Add(new Product(900, "mesa"));
            products.Add(new Product(900, "poste"));
            products.Add(new Product(90, "cachorro"));

            List<string> nameUpper = products.Select(p => p.Name.ToUpper()).ToList();
            nameUpper.ForEach(p => { Console.WriteLine(p); });
            
        }

    }
    class Product
    {
        public double Valor { get; set; }
        public string Name { get; set; }
        public Product(double valor, string name)
        {
            Valor= valor;
            Name= name;
        }

        public override string ToString()
        {
            return Valor + ", " + Name;
        }
    }
}