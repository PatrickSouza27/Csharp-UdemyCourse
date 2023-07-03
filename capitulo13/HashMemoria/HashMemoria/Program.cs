using System;


namespace x
{
    class Program
    {
        static void Main()
        {
            HashSet<Product> products = new HashSet<Product>();
            products.Add(new Product("TV", 900));
            products.Add(new Product("Notebook", 1200));

            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(3, 4));
            points.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200);
            Console.WriteLine(products.Contains(prod));

            Point x = new Point(3, 4);
            Console.WriteLine(points.Contains(x));
        }
    }
    struct Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y): this()
        {
            this.x = x;
            this.y = y;
        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(obj is not Product)
            {
                return false;
            }
            Product p = (Product)obj;
            return Name.Equals(p.Name) && Price.Equals(p.Price);
        }
    }
}