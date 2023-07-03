namespace CompararProduto
{
    class Product : IComparable
    {
        public string? Id { get; set; }
        public double Price { get; set; }

        public Product(string? id, double price)
        {
            Id = id;
            Price = price;
        }
        public int CompareTo(object? obj)
        {
            if (!(obj is Product))
            {
                throw new InvalidOperationException("Error, Tipagem Errada!");
            }
            Product Other = obj as Product;
            return Id.CompareTo(Other.Id);
        }

        public override string ToString()
        {
            return ($"Nome: {Id}\nPrice: {Price}");
        }
    }
}
