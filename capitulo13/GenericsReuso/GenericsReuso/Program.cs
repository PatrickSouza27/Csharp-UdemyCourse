using GenericsReuso;
using System;


namespace ex
{
    class Program
    {
        static void Main()
        {
            PrintService<string> x = new PrintService<string>();
            Console.Write("How many values: ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Value {0}", i + 1);
                x.AddValue(Console.ReadLine());
            }
            Console.WriteLine("First {0}", x.First());

            Console.WriteLine("Numbers: ");
            x.Print();
        }
    }
}
