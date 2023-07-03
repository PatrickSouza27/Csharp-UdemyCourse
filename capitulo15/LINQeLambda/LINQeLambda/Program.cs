using System;
using System.ComponentModel;

namespace x
{
    class Program
    {
        static void Printer<T>(string Message, IEnumerable<T> Ts)
        {
            Console.WriteLine(Message);
            foreach(T t in Ts)
            {
                Console.WriteLine(t);
            }
        }
        static void Main(string[] args)
        {
            Category category= new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category category2 = new Category() { Id = 1, Name = "Computers", Tier = 3 };
            Category category3 = new Category() { Id = 1, Name = "Eletronics", Tier = 1 };
            List<Product> products = new List<Product>();
            products.Add(new Product(3, "Computer", 1100.0, category2));
            products.Add(new Product(3, "TV", 90.0, category));
            products.Add(new Product(3, "SAW", 1700.0, category3));
            products.Add(new Product(3, "Tablete", 1300.0, category2));
            products.Add(new Product(3, "camera", 80.0, category));
            products.Add(new Product(3, "printer", 700.0, category2));
            products.Add(new Product(3, "MacBook", 700.0, category3));
            products.Add(new Product(3, "Lvel", 350.0, category3));
            products.Add(new Product(3, "SoundBar", 350.0, category2));
            products.Add(new Product(3, "Hammer", 350.0, category3));
            products.Add(new Product(3, "Computer", 350.0, category));


            var s = products.Where(x=> x.Prince < 900 && x.Category.Tier== 1).ToList();
            Printer("Cabeçalho", s);

            var s1 = products.Where(x => x.Category.Name == "Tools");
            Printer("Cabeçalho 2", s1);


            var s2 = products.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            Printer("Cabeçalho 3", s2);

            var s3 = products.Where(x => x.Name[0] == 'C');
            Printer("Cabeçalho 4", s3);

            var s4 = products.Where(x => x.Name[0] == 'C').Select(x => x.Name + " " + x.Prince + " " + x.Category.Name);
            Printer("Cabeçalho 5", s4);

            var s5 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Prince).ThenBy(x=> x.Name);
            Printer("Cabeçalho 6", s5);

            var s6 = s5.Skip(2).Take(1);
            Printer("Cabeçalho 7", s6);

            var s7 = s.First();

            
        }
    }
    class Product
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public double Prince { get; set; }
        public Category Category { get; set; }
        public Product(int id, string name, double prince, Category category)
        {
            Id = id;
            Name = name;
            Prince = prince;
            Category = category;
        }
        public override string ToString()
        {
            return $"id: {Id} Name: {Name} Price: {Prince.ToString("f2")} Categoria// {Category}";
        }
    }
    class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Tier { get; set; }
        public Category()
        {

        }

        public Category(int id, string? name, int tier)
        {
            Id = id;
            Name = name;
            Tier = tier;
        }

        public override string ToString()
        {
            return $"Name: {Name} Tier: {Tier}";
        }
    }
}
