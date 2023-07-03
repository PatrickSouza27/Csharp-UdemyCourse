using GetHashCodeEEquals;
using System;


namespace HashEquals
{
    class Program
    {
        static void Main()
        {
            Cliente x = new("Maria", "Maria@gmail.com");
            Cliente y = new("Joao", "Maria@gmail.com");

            Console.WriteLine(x.Equals(y));
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(y.GetHashCode());
        }
    }
}
