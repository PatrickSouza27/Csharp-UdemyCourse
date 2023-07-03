using System;

namespace ex
{
    class Program
    {
        static void Main()
        {
            List<Product> x = new List<Product>();
            x.Add(new Product("Tv", 900.00));
            x.Add(new Product("Mouse", 50.00));
            x.Add(new Product("Tablet", 350.50));
            x.Add(new Product("HD Case", 80.90));
            x.RemoveAll(func => func.Price >= 100.00);
            foreach(Product p in x) {
                Console.WriteLine(p);
            }
        }
    }
    class Product
    {
        public string Name { get; private set; } 
        public double Price { get; private set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return Name + "," + Price;
        }
    }
}